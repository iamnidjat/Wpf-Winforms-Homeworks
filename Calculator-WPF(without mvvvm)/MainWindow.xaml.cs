using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num1, num2;
        int oper;

        public MainWindow()
        {
            InitializeComponent();

            button0.Click += button0_Click;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button8_Click;
            button9.Click += button9_Click;
            buttonDivide.Click += buttonDivide_Click;
            buttonPlus.Click += buttonPlus_Click;
            buttonMultiply.Click += buttonMultiply_Click;
            buttonSubtract.Click += buttonSubtract_Click;
            buttonEquals.Click += buttonEquals_Click;
            buttonC.Click += buttonC_Click;
            buttonCE.Click += buttonCE_Click;
            buttonPow.Click += buttonPow_Click;
            buttonPoint.Click += buttonPoint_Click;
        }

        private void buttonPoint_Click(object sender, RoutedEventArgs e)
        {
            if (InputBox.Text == string.Empty || InputBox.Text[InputBox.Text.Length - 1] == ' ')
            {
                return;
            }
            else
            {
                InputBox.Text += ",";
            }           
        }

        private void buttonPow_Click(object sender, RoutedEventArgs e)
        {
            if (InputBox.Text == string.Empty || InputBox.Text[InputBox.Text.Length - 1] == ' ')
            {
                return;
            }
            else
            {
                InputBox.Text += " ^ ";
                oper = 5;
            }           
        }

        private void buttonCE_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OutputBox.Text == string.Empty && InputBox.Text[InputBox.Text.Length - 1] != ' ')
                {
                    try
                    {
                        InputBox.Text = InputBox.Text.Remove(InputBox.Text.Length - 1);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        throw new ArgumentOutOfRangeException("Incorrect datas!");
                    }
                }
                else if (OutputBox.Text == string.Empty && InputBox.Text[InputBox.Text.Length - 1] == ' ')
                {
                    try
                    {
                        InputBox.Text = InputBox.Text.Remove(InputBox.Text.Length - 1);
                        InputBox.Text = InputBox.Text.Remove(InputBox.Text.Length - 1);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        throw new ArgumentOutOfRangeException("Incorrect datas!");
                    }
                }
                else
                {
                    OutputBox.Clear();
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("Incorrect datas!");
            }
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Clear();
            OutputBox.Clear();
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            if (InputBox.Text != string.Empty && InputBox.Text[InputBox.Text.Length - 1] != ' ' && (InputBox.Text.Contains('+') || InputBox.Text.Contains('-') || InputBox.Text.Contains('^') || InputBox.Text.Contains('*') || InputBox.Text.Contains('/')))
            {
                InputBox.Clear();
                InputBox.Text = OutputBox.Text;
                OutputBox.Clear();
            }
        }

        private void buttonSubtract_Click(object sender, RoutedEventArgs e)
        {
            if (InputBox.Text == string.Empty || InputBox.Text[InputBox.Text.Length - 1] == ' ')
            {
                return;
            }
            else
            {
                InputBox.Text += " - ";
                oper = 2;
            }           
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (InputBox.Text == string.Empty || InputBox.Text[InputBox.Text.Length - 1] == ' ')
            {
                return;
            }
            else
            {
                InputBox.Text += " * ";
                oper = 3;
            }
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (InputBox.Text == string.Empty || InputBox.Text[InputBox.Text.Length - 1] == ' ')
            {
                return;
            }
            else
            {
                InputBox.Text += " + ";
                oper = 1;
            }
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            if (InputBox.Text == string.Empty || InputBox.Text[InputBox.Text.Length - 1] == ' ')
            {
                return;
            }
            else
            {
                InputBox.Text += " / ";
                oper = 4;
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            InputBox.Text += "9";

            for (int i = 0; i < InputBox.Text.Length; i++)
            {
                if (InputBox.Text[i] == ' ')
                {
                    count++;
                }
            }

            if (count > 2)
            {
                calculateMoreOperations();
            }

            else if(count == 2)
            {
                calculate();
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            InputBox.Text += "8";

            for (int i = 0; i < InputBox.Text.Length; i++)
            {
                if (InputBox.Text[i] == ' ')
                {
                    count++;
                }
            }

            if (count > 2)
            {
                calculateMoreOperations();
            }

            else if (count == 2)
            {
                calculate();
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            InputBox.Text += "7";

            for (int i = 0; i < InputBox.Text.Length; i++)
            {
                if (InputBox.Text[i] == ' ')
                {
                    count++;
                }
            }

            if (count > 2)
            {
                calculateMoreOperations();
            }

            else if (count == 2)
            {
                calculate();
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            InputBox.Text += "6";

            for (int i = 0; i < InputBox.Text.Length; i++)
            {
                if (InputBox.Text[i] == ' ')
                {
                    count++;
                }
            }

            if (count > 2)
            {
                calculateMoreOperations();
            }

            else if (count == 2)
            {
                calculate();
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            InputBox.Text += "5";

            for (int i = 0; i < InputBox.Text.Length; i++)
            {
                if (InputBox.Text[i] == ' ')
                {
                    count++;
                }
            }

            if (count > 2)
            {
                calculateMoreOperations();
            }

            else if (count == 2)
            {
                calculate();
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            InputBox.Text += "4";

            for (int i = 0; i < InputBox.Text.Length; i++)
            {
                if (InputBox.Text[i] == ' ')
                {
                    count++;
                }
            }

            if (count > 2)
            {
                calculateMoreOperations();
            }

            else if (count == 2)
            {
                calculate();
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            InputBox.Text += "3";

            for (int i = 0; i < InputBox.Text.Length; i++)
            {
                if (InputBox.Text[i] == ' ')
                {
                    count++;
                }
            }

            if (count > 2)
            {
                calculateMoreOperations();
            }

            else if (count == 2)
            {
                calculate();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            InputBox.Text += "2";

            for (int i = 0; i < InputBox.Text.Length; i++)
            {
                if (InputBox.Text[i] == ' ')
                {
                    count++;
                }
            }

            if (count > 2)
            {
                calculateMoreOperations();
            }

            else if (count == 2)
            {
                calculate();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            InputBox.Text += "1";

            for (int i = 0; i < InputBox.Text.Length; i++)
            {
                if (InputBox.Text[i] == ' ')
                {
                    count++;
                }
            }

            if (count > 2)
            {
                calculateMoreOperations();
            }

            else if (count == 2)
            {
                calculate();
            }
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            InputBox.Text += "0";

            for (int i = 0; i < InputBox.Text.Length; i++)
            {
                if (InputBox.Text[i] == ' ')
                {
                    count++;
                }
            }

            if (count > 2)
            {
                calculateMoreOperations();
            }

            else if (count == 2)
            {
                calculate();
            }
        }

        private void calculate()
        {
            switch (oper)
            {
                case 1:
                    {
                        try
                        {
                            string[] operands = InputBox.Text.Split("+");

                            for (int i = 0; i < operands.Length; i++)
                            {
                                operands[i] = operands[i].Trim();
                            }

                            num1 = double.Parse(operands[0]);
                            num2 = double.Parse(operands[1]);

                            OutputBox.Text = (num1 + num2).ToString();
                        }
                        catch (FormatException)
                        {
                            throw new FormatException("Incorrect datas!");
                        }

                        break;
                    }
                case 2:
                    {
                        try
                        {
                            string[] operands = InputBox.Text.Split("-");

                            for (int i = 0; i < operands.Length; i++)
                            {
                                operands[i] = operands[i].Trim();
                            }

                            num1 = double.Parse(operands[0]);
                            num2 = double.Parse(operands[1]);

                            OutputBox.Text = (num1 - num2).ToString();
                        }
                        catch (FormatException)
                        {
                            throw new FormatException("Incorrect datas!");
                        }

                        break;
                    }
                case 3:
                    {
                        try
                        {
                            string[] operands = InputBox.Text.Split("*");

                            for (int i = 0; i < operands.Length; i++)
                            {
                                operands[i] = operands[i].Trim();
                            }

                            num1 = double.Parse(operands[0]);
                            num2 = double.Parse(operands[1]);

                            OutputBox.Text = (num1 * num2).ToString();
                        }
                        catch (FormatException)
                        {
                            throw new FormatException("Incorrect datas!");
                        }

                        break;
                    }
                case 4:
                    {
                        try
                        {
                            string[] operands = InputBox.Text.Split("/");

                            for (int i = 0; i < operands.Length; i++)
                            {
                                operands[i] = operands[i].Trim();
                            }

                            num1 = double.Parse(operands[0]);
                            num2 = double.Parse(operands[1]);

                            OutputBox.Text = (num1 / num2).ToString();
                        }
                        catch (FormatException)
                        {
                            throw new FormatException("Incorrect datas!");
                        }

                        break;
                    }
                case 5:
                    {
                        try
                        {
                            string[] operands = InputBox.Text.Split("^");

                            for (int i = 0; i < operands.Length; i++)
                            {
                                operands[i] = operands[i].Trim();
                            }

                            num1 = double.Parse(operands[0]);
                            num2 = double.Parse(operands[1]);

                            OutputBox.Text = (Math.Pow(num1, num2)).ToString();
                        }
                        catch (FormatException)
                        {
                            throw new FormatException("Incorrect datas!");
                        }

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void calculateMoreOperations()
        {
            try
            {
                var expr = Convert.ToDouble(new DataTable().Compute(InputBox.Text, ""));
                OutputBox.Text = expr.ToString();
            }
            catch (SyntaxErrorException)
            {
                throw new SyntaxErrorException("Incorrect datas!");
            }
            catch (EvaluateException)
            {
                throw new EvaluateException("Incorrect datas!");
            }
        }
    }
}
