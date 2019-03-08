using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double save1;
        double save2;
        double finalResult;
        string currentOperator = "";
        bool resetText = false;
        bool operatorUsed = false;
        bool commaUsed = false;

        public Form1()
        {
            InitializeComponent();
        }

        //Happens when any number (or the point button) is clicked
        private void Numbers_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            //Makes cool deleting text effect after the user presses an operator
            if (resetText)
            {
                textBox.Text = "";
                commaUsed = false;
                resetText = false;
            }
                //Draws the numbers on the textbox when clicked
                //Cool 0 & comma effects
                if (textBox.Text != "0" || clickedButton.Text != "0") {
                    if (clickedButton.Text == ".") {
                        if (!commaUsed)
                        {
                            textBox.Text += clickedButton.Text;
                            commaUsed = true;
                        }
                    }
                    else if (clickedButton.Text != ".")
                    {
                        if (textBox.Text == "0")
                        {
                            textBox.Text = clickedButton.Text;
                        }
                        else
                        {
                            textBox.Text += clickedButton.Text;
                        }
                    }
                }
        }

        //Saves the operator used
        private void operator_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (textBox.Text != "") {
                save1 = Convert.ToDouble(textBox.Text);
                resetText = true;
                operatorUsed = true;
                currentOperator = clickedButton.Text;
            }
        }

        //Handles the math and outputs a final result depending on the operator used
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (currentOperator == "+")
            {
                save2 = Convert.ToDouble(textBox.Text);
                finalResult = save1 + save2;

                textBox.Text = Convert.ToString(finalResult);
                resetText = true;
            }
            if (currentOperator == "-")
            {
                save2 = Convert.ToDouble(textBox.Text);
                finalResult = save1 - save2;

                textBox.Text = Convert.ToString(finalResult);
                resetText = true;
            }
            if (currentOperator == "x")
            {
                save2 = Convert.ToDouble(textBox.Text);
                finalResult = save1 * save2;

                textBox.Text = Convert.ToString(finalResult);
                resetText = true;
            }
            if (currentOperator == "/")
            {
                save2 = Convert.ToDouble(textBox.Text);
                finalResult = save1 / save2;

                textBox.Text = Convert.ToString(finalResult);
                resetText = true;
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0) {
                if (textBox.Text[textBox.Text.Length - 1] == '.')
                {
                    commaUsed = false;
                }

                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
        }

        //Resets everything
        private void cButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            resetText = true;
            operatorUsed = false;
            currentOperator = "";
            save1 = 0;
            save2 = 0;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allows the user to insert numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal comma
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //Reverts the number from minus to plus and vice versa
        private void plusMinus_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != "0" && textBox.Text != "0.") {
                if (textBox.Text[0] != '-')
                {
                    textBox.Text = '-' + textBox.Text;
                }
                else
                {
                    textBox.Text = textBox.Text.Substring(1, textBox.Text.Length - 1);
                }
            }
        }
    }
}
