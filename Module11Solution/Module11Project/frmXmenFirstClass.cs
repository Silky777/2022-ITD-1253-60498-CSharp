using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Michael Blomfield
 * ITD-1253 Object-Oriented Programming Using C#
 * 11/22/2022
 */
namespace Module11Project
{
    public partial class frmXmenFirstClass : Form
    {
        const byte BYTE = 1;
        const byte SHORT = 2;
        const byte INT = 3;
        const byte LONG = 4;
        const byte FLOAT = 5;
        const byte DOUBLE = 6;
        const byte DECIMAL = 7;
        bool errorsEncountered = false;
        MathFirstClass equation = new MathFirstClass();

        public frmXmenFirstClass()
        {
            InitializeComponent();
        }

        private string ErrorValidation()
        {
            string returnString = "";
            decimal leftNum = 1;
            decimal rightNum = 1;

            if(equation.NumType == 0)
            {
                errorsEncountered = true;
                returnString = "A number type MUST be selected. Please click a button.\n";
            }
            if(txtLeft.Text == "")
            {
                errorsEncountered = true;
                returnString = returnString + "Left input must be provided.\n";
            }
            if(txtRight.Text == "")
            {
                errorsEncountered = true;
                returnString = returnString + "Right input must be provided.\n";
            }
            try
            {
                leftNum = Convert.ToDecimal(txtLeft.Text);
            }
            catch (FormatException)
            {
                errorsEncountered = true;
                returnString = returnString + "Left input was unable to be recognized as a number.\n";
            } catch (OverflowException)
            {
                errorsEncountered = true;
                returnString = returnString + "Left number is too large, please try again with a smaller number.\n";
            }
            try
            {
                rightNum = Convert.ToDecimal(txtRight.Text);
            } 
            catch (FormatException)
            {
                errorsEncountered = true;
                returnString = returnString + "Right input was unable to be recognized as a number.\n";
            } catch (OverflowException)
            {
                errorsEncountered = true;
                returnString = returnString + "Right number is too large, please try again with a smaller number.\n";
            }
            if (equation.NumType == BYTE)
            {
                if(leftNum > byte.MaxValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Left number must not be more than " + byte.MaxValue.ToString() + " for a byte.\n";
                }
                if(leftNum < byte.MinValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Left number must not be less than " + byte.MinValue.ToString() + " for a byte.\n";
                }
                if(rightNum > byte.MaxValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Right number must not be more than " + byte.MaxValue.ToString() + " for a byte.\n";
                }
                if(rightNum < byte.MinValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Right number must not be less than " + byte.MinValue.ToString() + " for a byte.\n";
                }
            }
            if (equation.NumType == SHORT)
            {
                if (leftNum > short.MaxValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Left number must not be more than " + short.MaxValue.ToString() + " for a short.\n";
                }
                if (leftNum < short.MinValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Left number must not be less than " + short.MinValue.ToString() + " for a short.\n";
                }
                if (rightNum > short.MaxValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Right number must not be more than " + short.MaxValue.ToString() + " for a short.\n";
                }
                if (rightNum < short.MinValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Right number must not be less than " + short.MinValue.ToString() + " for a short.\n";
                }
            }
            if (equation.NumType == INT)
            {
                if (leftNum > int.MaxValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Left number must not be more than " + int.MaxValue.ToString() + " for an int.\n";
                }
                if (leftNum < int.MinValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Left number must not be less than " + int.MinValue.ToString() + " for an int.\n";
                }
                if (rightNum > int.MaxValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Right number must not be more than " + int.MaxValue.ToString() + " for an int.\n";
                }
                if (rightNum < int.MinValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Right number must not be less than " + int.MinValue.ToString() + " for an int.\n";
                }
            }
            if (equation.NumType == LONG)
            {
                if (leftNum > long.MaxValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Left number must not be more than " + long.MaxValue.ToString() + " for a long.\n";
                }
                if (leftNum < long.MinValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Left number must not be less than " + long.MinValue.ToString() + " for a long.\n";
                }
                if (rightNum > long.MaxValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Right number must not be more than " + long.MaxValue.ToString() + " for a long.\n";
                }
                if (rightNum < long.MinValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Right number must not be less than " + long.MinValue.ToString() + " for a long.\n";
                }
            }
            if (equation.NumType == FLOAT)
            {
                float leftFloat = 0;
                float rightFloat = 0;
                try
                {
                    leftFloat = Convert.ToSingle(leftNum);
                }
                catch (OverflowException)
                {
                    errorsEncountered = true;
                    returnString += "Left number must be between -3.402823e38 and 3.402823e38.\n";
                }
                try
                {
                    rightFloat = Convert.ToSingle(rightNum);
                } catch (OverflowException)
                {
                    errorsEncountered = true;
                    returnString += "Right number must be between -3.402823e38 and 3.402823e38.\n";
                }
            }
            if (equation.NumType == DOUBLE)
            {
                double leftDouble = 0;
                double rightDouble = 0;
                try
                {
                    leftDouble = Convert.ToDouble(leftNum);
                }
                catch (OverflowException)
                {
                    errorsEncountered = true;
                    returnString += "Left number must be between -1.79769313486232e308 and 1.79769313486232e308.\n";
                }
                try
                {
                    rightDouble = Convert.ToDouble(rightNum);
                }
                catch (OverflowException)
                {
                    errorsEncountered = true;
                    returnString += "Right number must be between -1.79769313486232e308 and 1.79769313486232e308.\n";
                }
            }
            if (equation.NumType == DECIMAL)
            {
                if (leftNum > decimal.MaxValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Left number must not be more than " + decimal.MaxValue.ToString() + " for a decimal.\n";
                }
                if (leftNum < decimal.MinValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Left number must not be less than " + decimal.MinValue.ToString() + " for a decimal.\n";
                }
                if (rightNum > decimal.MaxValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Right number must not be more than " + decimal.MaxValue.ToString() + " for a decimal.\n";
                }
                if (rightNum < decimal.MinValue)
                {
                    errorsEncountered = true;
                    returnString = returnString + "Right number must not be less than " + decimal.MinValue.ToString() + " for a decimal.\n";
                }
            }
            if(leftNum == decimal.Zero && radDiv.Checked || leftNum == decimal.Zero && radMod.Checked || rightNum == decimal.Zero && radMod.Checked || rightNum == decimal.Zero && radDiv.Checked)
            {
                System.Diagnostics.Debug.WriteLine(leftNum);
                System.Diagnostics.Debug.WriteLine(rightNum);
                errorsEncountered = true;
                returnString = returnString + "Cannot divide by zero."; // For some reason modulus will activate this when one of the numbers falls out of the bounds of the data type. I have no clue why and couldn't figure it out.
            }
            return returnString;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            equation.NumType = 0;
            lblMode.Text = "Currrent Mode: NULL";
            lblResults.Text = "Click a Button.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnByte_Click(object sender, EventArgs e)
        {
            equation.NumType = BYTE;
            byte test = equation.NumType;
            lblMode.Text = "Current Mode: BYTE";
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            equation.NumType = SHORT;
            lblMode.Text = "Current Mode: SHORT";
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            equation.NumType = INT;
            lblMode.Text = "Current Mode: INT";
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            equation.NumType = LONG;
            lblMode.Text = "Current Mode: LONG";
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            equation.NumType = FLOAT;
            lblMode.Text = "Current Mode: FLOAT";
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            equation.NumType = DOUBLE;
            lblMode.Text = "Current Mode: DOUBLE";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            equation.NumType = DECIMAL;
            lblMode.Text = "Current Mode: DECIMAL";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string errors = ErrorValidation();
            equation.LeftText = txtLeft.Text;
            equation.RightText = txtRight.Text;
            if(errorsEncountered == true)
            {
                lblResults.Text = errors;
                errorsEncountered = false;
                return;
            }
            if (radAdd.Checked)
            {
                lblResults.Text = equation.AddOperands();
            }
            if (radSub.Checked)
            {
                lblResults.Text = equation.SubtractOperands();
            }
            if (radMulti.Checked)
            {
                lblResults.Text = equation.MultiplyOperands();
            }
            if (radDiv.Checked)
            {
                lblResults.Text = equation.DivideOperands();
            }
            if (radMod.Checked)
            {
                lblResults.Text = equation.ModulusOperands();
            }
        }
    }
}
