// Alex Casper
// CPT-185
// Final Project Calculator
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alex_Casper_CPT_185_Final
{
    public partial class Form1 : Form
    {
        string userInput = "";
        double mem, result;
        /* operandList allows for dynamic amount of values
         * operatorChosen allows for dynamic operators
         * 1 is +, 2 is -, 3 is *, 4 is / */
        List<double> operandList = new List<double>();
        List<int> operatorChosen = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        // Number buttons simply add corresponding number to the input string and update calculator display
        private void BtnZero_Click(object sender, EventArgs e)
        {
            userInput += "0";
            txtDisplay.Text = userInput;
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            userInput += "1";
            txtDisplay.Text = userInput;
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            userInput += "2";
            txtDisplay.Text = userInput;
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            userInput += "3";
            txtDisplay.Text = userInput;
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            userInput += "4";
            txtDisplay.Text = userInput;
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            userInput += "5";
            txtDisplay.Text = userInput;
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            userInput += "6";
            txtDisplay.Text = userInput;
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            userInput += "7";
            txtDisplay.Text = userInput;
        }

        // Backspace removes latest input in the string and updates display
        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                userInput = userInput.Remove(userInput.Length - 1);
                txtDisplay.Text = userInput;
            }
            catch
            {
                MessageBox.Show("Cannot backspace more");
            }
        }

        // Exit button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Some more number buttons 
        private void BtnEight_Click(object sender, EventArgs e)
        {
            userInput += "8";
            txtDisplay.Text = userInput;
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            userInput += "9";
            txtDisplay.Text = userInput;
        }

        /* Decimal buton checks if there is a decimal in the string, if not it adds one to the string, 
         * if there is nothing in the string it adds a zero then a decimal to prevent 
         * the program from having a lone decimal, If the string does have a decimal it prevents another */
        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {
                userInput += "0.";
                txtDisplay.Text = userInput;
            }
            else if (userInput.Contains(".") == false)
            {
                userInput += ".";
                txtDisplay.Text = userInput;
            }
            else
                MessageBox.Show("Cannot have 2 decimal points");
            }

        /* Operation buttons see if the userinput is valid and adds it to the list of values, 
         * then adds the operators corresponding number to the operatorList, finally it updates the text box
         * and clears user input for another value */
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (userInput != "" && userInput != "-")
            {
                operandList.Add(double.Parse(userInput));
                operatorChosen.Add(1);
                txtOperation.Text += userInput + " + ";
                userInput = "";
                txtDisplay.Text = "";
            }
            else
                MessageBox.Show("Make a number selection before adding");
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (userInput != "" && userInput != "-")
            {
                operandList.Add(double.Parse(userInput));
                operatorChosen.Add(2);
                txtOperation.Text += userInput + " - ";
                userInput = "";
                txtDisplay.Text = "";
            }
            else
                MessageBox.Show("Make a number selection before subtracting");
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (userInput != "" && userInput != "-")
            {
                operandList.Add(double.Parse(userInput));
                operatorChosen.Add(3);
                txtOperation.Text += userInput + " * ";
                userInput = "";
                txtDisplay.Text = "";
            }
            else
                MessageBox.Show("Make a number selection before multiplying");
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (userInput != "" && userInput != "-")
            {
                operandList.Add(double.Parse(userInput));
                operatorChosen.Add(4);
                txtOperation.Text += userInput + " / ";
                userInput = "";
                txtDisplay.Text = "";
            }
            else
                MessageBox.Show("Make a number selection before dividing");
        }

        // Clear button
        private void BtnClear_Click(object sender, EventArgs e)
        {
            operandList.Clear();
            operatorChosen.Clear();
            result = 0;
            mem = 0;
            userInput = "";
            txtDisplay.Text = "";
            txtOperation.Text = "";
        }

        // Memory buttons, MC checks to see if the userInput string is valid, then parses it into the mem variable
        private void BtnMemory_Click(object sender, EventArgs e)
        {
            if  (userInput != "-" && userInput != ".")
            {
                if (userInput != "")
                    mem = double.Parse(userInput);
                else
                    MessageBox.Show("No input to store in memory");
            }
            else
                MessageBox.Show("Add a number to negative sign/decimal point");
        }

        // This button simply sets the mem value as userInput, returning it for use
        private void BtnMemReturn_Click(object sender, EventArgs e)
        {
            try
            {
                userInput = mem.ToString();
                txtDisplay.Text = userInput;
            }
            catch
            {
                MessageBox.Show("No value in memory to return");
            }
        }

        // Both these buttons check if userInput is valid, then add or subtract a parsed userInput to mem
        private void BtnMemPlus_Click(object sender, EventArgs e)
        {
            if (userInput != "" && userInput != "-")
                mem += double.Parse(userInput);
            else
                MessageBox.Show("No value in memory to add to, no input to add with, cannot add to stray negative sign");
        }

        private void BtnMemMinus_Click(object sender, EventArgs e)
        {
            if (userInput != "" && userInput != "-")
                mem -= double.Parse(userInput);
            else
                MessageBox.Show("No value in memory to subtract to, no input to subtract from, cannot subtract stray negative sign");
        }
        
        /* The equals button starts by making sure there are values and operators in the lists to use,  then
         * if the userInput string is valid it runs a loop that sets the first value to the result
         * and each loop it does whatever operation is next with the next value to the result.
         * It then adds the total calculation to the list box as a history and clears everything except the memory
         value*/
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (operandList.Count == 0 && operatorChosen.Count == 0)
                MessageBox.Show("Make an equation first");
            else if (userInput == "")
                MessageBox.Show("Add final number to equation or choose 0 if done then press = again");
            else
            {
                operandList.Add(double.Parse(userInput));
                for (int i = 0; i < operatorChosen.Count + 1; i++)
                {
                    if (i == 0)
                        result = operandList[i];
                    else
                    {
                        if (operatorChosen[i - 1].Equals(1) == true)
                            result += operandList[i];
                        else if (operatorChosen[i - 1].Equals(2) == true)
                            result -= operandList[i];
                        else if (operatorChosen[i - 1].Equals(3) == true)
                            result *= operandList[i];
                        else if (operatorChosen[i - 1].Equals(4) == true)
                            result /= operandList[i];
                    }
                }
                lstPastCalcs.Items.Add(txtOperation.Text + userInput + " = " + result.ToString());
                txtOperation.Text = "";
                operandList.Clear();
                operatorChosen.Clear();
                userInput = result.ToString();
                txtDisplay.Text = userInput;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm About = new AboutForm();
            About.ShowDialog();
        }

        // This button adds or removes a - at the beginning of the userInput string, making the parse negative or positive
        private void BtnPosNeg_Click(object sender, EventArgs e)
        {
            if (userInput.Contains("-") == true)
                userInput = userInput.Remove(0, 1);
            else
               userInput = userInput.Insert(0, "-");
            txtDisplay.Text = userInput;
        }
    }
}
