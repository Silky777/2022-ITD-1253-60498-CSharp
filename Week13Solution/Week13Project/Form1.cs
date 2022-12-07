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

namespace Week13Project
{
    /*
     * <Name Removed>
     * ITD-1253 Object-Oriented Programming with C#
     * 12/06/2022
     */
    public partial class frmWeek13 : Form
    {
        // Class level variables
        private CustomerList customers = new CustomerList();
        bool errorsEncountered = false;
        int selectedIndex = -1;

        public frmWeek13()
        {
            InitializeComponent();
        }

        // Methods
        private string customerValidation()
        {
            string returnString = string.Empty;
            Regex validZip = new Regex("^[0-9]{5}(?:-[0-9]{4})?$");
            Regex validPhone = new Regex("^\\d\\d\\d-\\d\\d\\d-\\d\\d\\d\\d$");
            Regex residentialID = new Regex("^[a-zA-Z][a-zA-Z]\\d-[a-zA-Z]\\d\\d-[a-zA-Z][a-zA-Z]$"); // Pattern: AA#-A##-AA
            Regex commercialID = new Regex("^\\d[a-zA-Z][a-zA-Z]\\d-[a-zA-Z]\\d-[a-zA-Z]\\d[a-zA-Z]\\d$"); // Pattern: #AA#-A#-A#A#
            Regex governmentID = new Regex("^\\d[a-zA-Z][a-zA-Z][a-zA-Z]-[a-zA-Z][a-zA-Z][a-zA-Z][a-zA-Z]-[a-zA-Z][a-zA-Z]\\d\\d$"); // Pattern: #AAA-AAAA-AA##
            // Validate First Name
            if (txtFirstName.Text.Trim() == string.Empty)
            {
                returnString += "First name must be provided." + Environment.NewLine;
                errorsEncountered = true;
            }
            // Validate Middle Name
            if (txtMiddleName.Text.Trim() == string.Empty)
            {
                returnString += "Middle name must be provided." + Environment.NewLine;
                errorsEncountered = true;
            }
            // Validate Last Name
            if (txtLastName.Text.Trim() == string.Empty)
            {
                returnString += "Last name must be provided." + Environment.NewLine;
                errorsEncountered = true;
            }
            // Validate Address Line 1
            if (txtAddress1.Text.Trim() == string.Empty)
            {
                returnString += "Address 1 must be provided." + Environment.NewLine;
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
                errorsEncountered = true;
            } else if (coboState.Text.Trim() == "- no selection -")
            {
                returnString += "State must be provided." + Environment.NewLine;
                errorsEncountered = true;
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
            // Validate Contact Number
            if (txtExtra1.Text.Trim() == string.Empty)
            {
                returnString += "Contact number must be provided." + Environment.NewLine;
                errorsEncountered = true;
            }
            else if (!validPhone.IsMatch(txtExtra1.Text.Trim()))
            {
                returnString += "Contact number is an an incorrect format." + Environment.NewLine;
                errorsEncountered = true;
            }
            // Validate ID
            if (txtExtra3.Text.Trim() == string.Empty)
            {
                returnString += "ID must be provided." + Environment.NewLine;
                errorsEncountered = true;
            }
            if (radResidential.Checked && !residentialID.IsMatch(txtExtra3.Text.Trim()))
            {
                returnString += "ID is in an incorrect format: AA#-A##-AA";
                errorsEncountered = true;
            }
            if (radCommercial.Checked && !commercialID.IsMatch(txtExtra3.Text.Trim()))
            {
                returnString += "ID is in an incorrect format: #AA#-A#-A#A#";
                errorsEncountered = true;
            }
            if (radGovernment.Checked && !governmentID.IsMatch(txtExtra3.Text.Trim()))
            {
                returnString += "ID is in an incorrect format: #AAA-AAAA-AA##";
                errorsEncountered = true;
            }
            return returnString;
        }
        private void ClearInputBoxes()
        {
            txtFirstName.Text = string.Empty;
            txtMiddleName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtAddress1.Text = string.Empty;
            txtAddress2.Text = string.Empty;
            txtCity.Text = string.Empty;
            coboState.SelectedIndex = -1;
            txtZip.Text = string.Empty;
            txtExtra1.Text = string.Empty;
            txtExtra2.Text = string.Empty;
            txtExtra3.Text = string.Empty;
        }

        // Button Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            string errors = customerValidation();
            if (!errorsEncountered)
            {
                if (radResidential.Checked)
                {
                    customers.Add(new ResidentialCustomer(txtFirstName.Text.Trim(), txtMiddleName.Text.Trim(),
                        txtLastName.Text.Trim(), txtAddress1.Text.Trim(), txtAddress2.Text.Trim(),
                        txtCity.Text.Trim(), coboState.Text.Trim(), txtZip.Text.Trim(),
                        txtExtra1.Text.Trim(), txtExtra2.Text.Trim(), txtExtra3.Text.Trim()));
                }
                if (radCommercial.Checked)
                {
                    customers.Add(new CommercialCustomer(txtFirstName.Text.Trim(), txtMiddleName.Text.Trim(),
                        txtLastName.Text.Trim(), txtAddress1.Text.Trim(), txtAddress2.Text.Trim(),
                        txtCity.Text.Trim(), coboState.Text.Trim(), txtZip.Text.Trim(),
                        txtExtra1.Text.Trim(), txtExtra2.Text.Trim(), txtExtra3.Text.Trim()));
                }
                if (radGovernment.Checked)
                {
                    customers.Add(new GovernmentCustomer(txtFirstName.Text.Trim(), txtMiddleName.Text.Trim(),
                        txtLastName.Text.Trim(), txtAddress1.Text.Trim(), txtAddress2.Text.Trim(),
                        txtCity.Text.Trim(), coboState.Text.Trim(), txtZip.Text.Trim(),
                        txtExtra1.Text.Trim(), txtExtra2.Text.Trim(), txtExtra3.Text.Trim()));
                }
                ClearInputBoxes();
                return;
            }
            txtOutput.Text = errors;
            errorsEncountered = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            ClearInputBoxes();
            radResidential.Checked = true;
            dataOutput.Rows.Clear();
            txtFirstName.Focus();
        }
        private void btnListAll_Click(object sender, EventArgs e)
        {
            if (customers.Count == 0)
            {
                dataOutput.Rows.Clear();
                txtOutput.Text += Environment.NewLine + "No customers to display."; // Prevent any array errors here.
                return;
            }
            selectedIndex = -1;
            btnRemove.Enabled = false;
            dataOutput.Rows.Clear();
            for(int i = 0; i < customers.Count; i++)
            {
                string[] returnArr = new string[7];
                returnArr[6] = i.ToString();
                customers[i].returnData().CopyTo(returnArr, 0);
                dataOutput.Rows.Add(returnArr);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
            {
                txtOutput.Text += Environment.NewLine + "Nothing to remove.";
                return;
            }
            customers.RemoveAt(selectedIndex); // SelectedIndex is set in dataOutput_CellClick
            btnListAll_Click(sender, e); // This just regenerates the customer list after removal
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Utility Events
        private void txtExtra1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                return;
            }
            if (txtExtra1.Text.Length == 3)
            {
                txtExtra1.Text += "-";
                txtExtra1.SelectionStart = txtExtra1.Text.Length;
            }
            if (txtExtra1.Text.Length == 7)
            {
                txtExtra1.Text += "-";
                txtExtra1.SelectionStart = txtExtra1.Text.Length;
            }
        }
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            if (radResidential.Checked)
            {
                txtOutput.Text = "ID Pattern: AA#-A##-AA";
                lblExtra1.Text = "Home #:";
                lblExtra2.Text = "House Type:";
                lblExtra3.Text = "Cust. ID:";
            }
        }
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            if (radCommercial.Checked)
            {
                txtOutput.Text = "ID Pattern: #AA#-A#-A#A#";
                lblExtra1.Text = "Company #:";
                lblExtra2.Text = "Business:";
                lblExtra3.Text = "Company ID:";
            }
        }
        private void radGovernment_CheckedChanged(object sender, EventArgs e)
        {
            if (radGovernment.Checked)
            {
                txtOutput.Text = "ID Pattern: #AAA-AAAA-AA##";
                lblExtra1.Text = "Contact #:";
                lblExtra2.Text = "Gov. Sector:";
                lblExtra3.Text = "Contract ID:";
            }
        }
        private void dataOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = Convert.ToInt32(dataOutput.CurrentRow.Cells[6].Value);
            System.Diagnostics.Debug.WriteLine(selectedIndex);
            if (selectedIndex != -1)
            {
                btnRemove.Enabled = true;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataOutput.CurrentCell = null;
            dataOutput.ClearSelection();
            dataOutput.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string search = txtSearch.Text;
            List<DataGridViewRow> validRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataOutput.Rows)
            {
                for(int i = 0; i < row.Cells.Count; i++)
                {
                    System.Diagnostics.Debug.WriteLine($"i : {i}");
                    var cellValue = row.Cells[i].Value;
                    System.Diagnostics.Debug.WriteLine(cellValue.ToString().ToLower());
                    if (cellValue.ToString().ToLower().Contains(search.ToLower()))
                    {
                        validRows.Add(row);
                    }
                }
                row.Visible = false;
            }
            foreach (DataGridViewRow row in validRows.Distinct())
            {
                row.Visible = true;
            }
        }
    }
}
