using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * <Name Removed>
 * ITD-1253 Object-Oriented Programming with C#
 * 12/06/2022
 */
namespace Week12Project
{
    public partial class Form1 : Form
    {
        // Class level variables
        private CustomerList customers = new CustomerList();
        int currCust = 0;
        bool keepText = false;
        bool errorsEncountered = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            updateCustomerBox();
            coboCustomerSelect.SelectedIndex = 0;
        }

        // Methods
        private string customerValidation()
        {
            string returnString = string.Empty;
            Regex validZip = new Regex("^[0-9]{5}(?:-[0-9]{4})?$");
            Regex validPhone = new Regex("\\d\\d\\d-\\d\\d\\d-\\d\\d\\d\\d");
            // Validate First Name
            if (txtFirstName.Text.Trim() == string.Empty)
            {
                returnString += "First name must be provided." + Environment.NewLine;
                errorsEncountered = true;
            }
            // Validate Last Name
            if (txtLastName.Text.Trim() == string.Empty)
            {
                returnString += "First name must be provided." + Environment.NewLine;
                errorsEncountered = true;
            }
            // Validate Address Line 1
            if (txtAddress1.Text.Trim() == string.Empty)
            {
                returnString += "Address line 1 must be provided." + Environment.NewLine;
                errorsEncountered = true;
            }
            // Validate Address Line 2
            if (txtCity.Text.Trim() == string.Empty)
            {
                returnString += "City must be provided." + Environment.NewLine;
                errorsEncountered = true;
            }
            // Validate State
            if (coboState.Text.Trim() == string.Empty)
            {
                returnString += "State must be provided." + Environment.NewLine;
            }
            // Validate Zip Code
            if (txtZip.Text.Trim() == string.Empty)
            {
                returnString += "Zip code must be provided." + Environment.NewLine;
                errorsEncountered = true;
            }
            else if (!validZip.IsMatch(txtZip.Text.Trim()))
            {
                returnString += "Zip code is in an incorrect format." + Environment.NewLine;
                errorsEncountered = true;
            }
            // Validate Phone Number
            if (txtPhone.Text.Trim() == string.Empty)
            {
                returnString += "Phone number must be provided." + Environment.NewLine;
                errorsEncountered = true;
            }
            else if (!validPhone.IsMatch(txtPhone.Text.Trim()))
            {
                returnString += "Phone number is an an incorrect format." + Environment.NewLine;
                errorsEncountered = true;
            }
            return returnString;
        }
        private void updateCustomerBox()
        {
            coboCustomerSelect.Items.Clear();
            coboCustomerSelect.Items.Insert(0, "- no customer selected -");
            for (int i = 0; i < customers.Count; i++)
            {
                coboCustomerSelect.Items.Add($"{customers[i].lastName}, {customers[i].firstName} - {customers[i].phoneNumber}" +
                    $" - {customers[i].city}, {customers[i].state} {customers[i].zipCode}");
            }
        }
        private void ClearInputBoxes()
        {
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtAddress1.Text = string.Empty;
            txtAddress2.Text = string.Empty;
            txtCity.Text = string.Empty;
            coboState.SelectedIndex = -1;
            txtZip.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }
        private void writeRichText(Customer cust, bool clear, bool intro = false, string hasBeen = "")
        {
            if (clear)
            {
                txtOutput.Clear();
            }
            Font normFont = new Font("Times New Roman", 14);
            Font boldFont = new Font("Times New Roman", 16, FontStyle.Bold);
            if (intro)
            {
                txtOutput.SelectionFont = normFont;
                txtOutput.SelectionIndent = 0;
                txtOutput.SelectedText = $"Customer has been {hasBeen}." + Environment.NewLine + Environment.NewLine;
            }
            txtOutput.SelectionFont = boldFont;
            txtOutput.SelectionIndent = 20;
            txtOutput.SelectedText = "Name: ";
            txtOutput.SelectionFont = normFont;
            txtOutput.SelectedText = $"{cust.firstName} {cust.lastName}" + Environment.NewLine;
            txtOutput.SelectionFont = boldFont;
            txtOutput.SelectionIndent = 2;
            txtOutput.SelectedText = $"Address: ";
            txtOutput.SelectionFont = normFont;
            if (cust.address2 != string.Empty)
            {
                txtOutput.SelectedText = cust.address1 + Environment.NewLine;
                txtOutput.SelectionFont = normFont;
                txtOutput.SelectionIndent = 86;
                txtOutput.SelectedText = cust.address2 + Environment.NewLine +
                    $"{cust.city}, {cust.state} {cust.zipCode}" + Environment.NewLine;
            }
            else
            {
                txtOutput.SelectedText = cust.address1 + Environment.NewLine;
                txtOutput.SelectionFont = normFont;
                txtOutput.SelectionIndent = 86;
                txtOutput.SelectedText = $"{cust.city}, {cust.state} {cust.zipCode}" + Environment.NewLine;
            }
            txtOutput.SelectionFont = boldFont;
            txtOutput.SelectionIndent = 0;
            txtOutput.SelectedText = "Phone #: ";
            txtOutput.SelectionFont = normFont;
            txtOutput.SelectedText = $"{cust.phoneNumber}" + Environment.NewLine + Environment.NewLine;
        }

        // Button Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string errors = customerValidation();
            if (customers.Count == 7) // Because of the way I coded this lab, this is actually an arbitrary limitation. It can handle just about any number of customers.
            {
                txtOutput.Clear();
                txtOutput.SelectionFont = new Font("Times New Roman", 14);
                txtOutput.SelectionIndent = 0;
                txtOutput.SelectedText = "Limit of 7 customers has been reached, cannot add another.";
                return;
            }
            if (!errorsEncountered && btnAdd.Text == "Add")
            {
                customers.Add(txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtAddress1.Text.Trim(),
                    txtAddress2.Text.Trim(), txtCity.Text.Trim(), coboState.Text.Trim(),
                    txtZip.Text.Trim(), txtPhone.Text.Trim());
                currCust = customers.Count - 1;
                writeRichText(customers[currCust], true, true, "added");
                updateCustomerBox();
                keepText = true; coboCustomerSelect.SelectedIndex = 0;
                ClearInputBoxes();
                txtLastName.Focus();
                return;
            }
            if (!errorsEncountered && btnAdd.Text == "Modify")
            {
                string message = $"Are you sure you'd like to modify customer \'{customers[currCust].firstName} {customers[currCust].lastName}\'?";
                DialogResult result = MessageBox.Show(message, "Modify Customer?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    customers[currCust].firstName = txtFirstName.Text.Trim();
                    customers[currCust].lastName = txtLastName.Text.Trim();
                    customers[currCust].address1 = txtAddress1.Text.Trim();
                    customers[currCust].address2 = txtAddress2.Text.Trim();
                    customers[currCust].city = txtCity.Text.Trim();
                    customers[currCust].state = coboState.Text.Trim();
                    customers[currCust].zipCode = txtZip.Text.Trim();
                    customers[currCust].phoneNumber = txtPhone.Text.Trim();
                    updateCustomerBox();
                    coboCustomerSelect.SelectedIndex = currCust + 1;
                    writeRichText(customers[currCust], true, true, "modified");
                }
                return;
            }
            txtOutput.Clear();
            txtOutput.SelectionFont = new Font("Times New Roman", 14);
            txtOutput.SelectionIndent = 0;
            txtOutput.SelectedText = errors;
            errorsEncountered = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputBoxes();
            txtOutput.Clear();
            coboCustomerSelect.SelectedIndex = 0;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure you'd like to delete customer \'{customers[currCust].firstName} {customers[currCust].lastName}\'?";
            DialogResult result = MessageBox.Show(message, "Delete Customer?", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (result == DialogResult.OK)
            {
                customers.Remove(customers[currCust]);
                updateCustomerBox();
                keepText = true; coboCustomerSelect.SelectedIndex = 0;
                ClearInputBoxes();
            }
        }
        private void btnLabels_Click(object sender, EventArgs e)
        {
            ClearInputBoxes();
            coboCustomerSelect.SelectedIndex = 0;
            txtOutput.WordWrap = false;
            txtOutput.Clear();
            for (int i = 0; i < customers.Count; i++)
            {
                writeRichText(customers[i], false); // The clear boolean being false means that the textbox isn't cleared each time this loops.
            }
            txtOutput.WordWrap = true;
        }
        private void btnOverload_Click(object sender, EventArgs e)
        {
            txtOutput.WordWrap = false;
            if (customers.Count > 1)
            {
                writeRichText(customers[0] + customers[1], true);
            }
            txtOutput.WordWrap = true;
        }

        // Utility Events
        private void coboCustomerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coboCustomerSelect.SelectedIndex != 0)
            {
                currCust = coboCustomerSelect.SelectedIndex - 1;
                txtFirstName.Text = customers[currCust].firstName;
                txtLastName.Text = customers[currCust].lastName;
                txtAddress1.Text = customers[currCust].address1;
                txtAddress2.Text = customers[currCust].address2;
                txtCity.Text = customers[currCust].city;
                coboState.Text = customers[currCust].state;
                txtZip.Text = customers[currCust].zipCode;
                txtPhone.Text = customers[currCust].phoneNumber;
                writeRichText(customers[currCust], true);
                btnAdd.Text = "Modify";
                btnRemove.Enabled = true;
            }
            else if (!keepText)
            {
                currCust = 0;
                ClearInputBoxes();
                txtOutput.Text = string.Empty;
                btnAdd.Text = "Add";
                btnRemove.Enabled = false;
            }
            else
            {
                currCust = 0;
                ClearInputBoxes();
                btnAdd.Text = "Add";
                btnRemove.Enabled = false;
                keepText = false;
            }
        }
        private void txtPhone_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                return;
            }
            if (txtPhone.Text.Length == 3)
            {
                txtPhone.Text += "-";
                txtPhone.SelectionStart = txtPhone.Text.Length;
            }
            if (txtPhone.Text.Length == 7)
            {
                txtPhone.Text += "-";
                txtPhone.SelectionStart = txtPhone.Text.Length;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
