using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double num1, num2;
        int oper;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Text == "0")
                {
                    textBox1.Text += "0";
                }

                if (button.Text == "1")
                {
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "1";
                    }
                    else
                    {
                        textBox1.Text += "1";
                    }
                }

                if (button.Text == "2")
                {
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "2";
                    }
                    else
                    {
                        textBox1.Text += "2";
                    }
                }

                if (button.Text == "3")
                {
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "3";
                    }
                    else
                    {
                        textBox1.Text += "3";
                    }
                }

                if (button.Text == "4")
                {
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "4";
                    }
                    else
                    {
                        textBox1.Text += "4";
                    }
                }

                if (button.Text == "5")
                {
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "5";
                    }
                    else
                    {
                        textBox1.Text += "5";
                    }
                }

                if (button.Text == "6")
                {
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "6";
                    }
                    else
                    {
                        textBox1.Text += "6";
                    }
                }

                if (button.Text == "7")
                {
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "7";
                    }
                    else
                    {
                        textBox1.Text += "7";
                    }
                }

                if (button.Text == "8")
                {
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "8";
                    }
                    else
                    {
                        textBox1.Text += "8";
                    }
                }

                if (button.Text == "9")
                {
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = "9";
                    }
                    else
                    {
                        textBox1.Text += "9";
                    }
                }
            }
        }

        private void buttonToDouble_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            oper = 1;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            oper = 2;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            oper = 3;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            oper = 4;
        }

        private void buttonRemainder_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            oper = 5;
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            oper = 6;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            switch (oper)
            {
                case 1:
                    {
                        num2 = num1 + double.Parse(textBox1.Text);
                        textBox1.Text = num2.ToString();
                        break;
                    }
                case 2:
                    {
                        num2 = num1 - double.Parse(textBox1.Text);
                        textBox1.Text = num2.ToString();
                        break;
                    }
                case 3:
                    {
                        num2 = num1 * double.Parse(textBox1.Text);
                        textBox1.Text = num2.ToString();
                        break;
                    }
                case 4:
                    {
                        num2  = num1 / double.Parse(textBox1.Text);
                        textBox1.Text = num2.ToString();
                        break;
                    }
                case 5:
                    {
                        num2 = num1 % double.Parse(textBox1.Text);
                        textBox1.Text = num2.ToString();
                        break;
                    }
                case 6:
                    {
                        num2 = Math.Pow(num1, double.Parse(textBox1.Text));
                        textBox1.Text = num2.ToString();
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }
    }
}
