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
        double FirstNumber;
        double SecondNumber;
        string Operator;
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";

            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";

            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";

            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";

            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        public void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";

            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        public void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";

            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        public void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";

            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        public void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";

            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        public void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";

            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        public void buttonDot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        public void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            Operator = "+";
            textBox2.Text = FirstNumber.ToString() + " " + Operator;
            textBox1.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            SecondNumber = Convert.ToDouble(textBox1.Text);
            textBox2.Text = $"{FirstNumber} {Operator} {SecondNumber} = ";
            switch (Operator)
            {
                case "+": 
                    textBox1.Text = (FirstNumber + SecondNumber).ToString();
                    break;

                case "-":
                    textBox1.Text = (FirstNumber - SecondNumber).ToString();
                    break;

                case "*":
                    textBox1.Text = (FirstNumber * SecondNumber).ToString();
                    break;

                case "%":
                    textBox1.Text = (FirstNumber % SecondNumber).ToString();
                    break;

                case "/":
                    if (SecondNumber != 0)
                    {
                        textBox1.Text = (FirstNumber / SecondNumber).ToString();
                    }
                    else
                    {
                        textBox1.Text = "Can not divide by zero";
                    }
                        break;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            Operator = "-";
            textBox2.Text = FirstNumber.ToString() + " " + Operator;
            textBox1.Clear();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            Operator = "*";
            textBox2.Text = FirstNumber.ToString() + " " + Operator;
            textBox1.Clear();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            Operator = "/";
            textBox2.Text = FirstNumber.ToString() + " " + Operator;
            textBox1.Clear();
        }

        private void buttonModulus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            Operator = "%";
            textBox2.Text = FirstNumber.ToString() + " " + Operator;
            textBox1.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonNegNumber_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text != null)
            {
                double currentNumber;

                if (double.TryParse(textBox1.Text, out currentNumber))
                {
                    currentNumber = -currentNumber;
                    textBox1.Text = currentNumber.ToString();

                    // Update FirstNumber or SecondNumber depending on whether an operator was selected
                    if (string.IsNullOrEmpty(Operator))
                    {
                        FirstNumber = currentNumber;
                    }
                    else
                    {
                        SecondNumber = currentNumber;
                    }
                }
            }
        }
    }
}
