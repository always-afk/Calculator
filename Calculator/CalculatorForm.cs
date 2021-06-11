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
    public partial class CalculatorForm : Form
    {
        private const double zero = 0.0;
        private const double one = 1.0;
        private const double two = 2.0;
        private const double three = 3.0;
        private const double four = 4.0;
        private const double five = 5.0;
        private const double six = 6.0;
        private const double seven = 7.0;
        private const double eight = 8.0;
        private const double nine = 9.0;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += zero; 
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += one;
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += two;
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += three;
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += four;
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += five;
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += six;
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += seven;
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += eight;
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += nine;
        }

        private void Button_RemoveOneNum_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Current.Text))
            {

            }
            else
            {
                textBox_Current.Text = textBox_Current.Text.TrimEnd(new char[]
                { textBox_Current.Text.ElementAt(textBox_Current.Text.Length - 1) });
            }
            
        }

        private void Button_RemoveOneElem_Click(object sender, EventArgs e)
        {
            textBox_Current.Text = textBox_Previous.Text;
            textBox_Operation.Text = null;
            textBox_Previous.Text = null;
        }

        private void Button_Point_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Current.Text))
            {
                textBox_Current.Text += "0,";
            }
            else
            {
                textBox_Current.Text += ",";
            }
        }       

        private void Button_RemoveAll_Click(object sender, EventArgs e)
        {
            textBox_Current.Text = null;
            textBox_Operation.Text = null;
            textBox_Previous.Text = null;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Current.Text))
            {
                return;
            }
            textBox_Operation.Text = button_Add.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
        }

        private void Button_Minus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Current.Text))
            {
                return;
            }
            textBox_Operation.Text = button_Minus.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
        }

        private void Button_Multiply_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Current.Text))
            {
                return;
            }
            textBox_Operation.Text = button_Multiply.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
        }

        private void Button_Split_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Current.Text))
            {
                return;
            }
            textBox_Operation.Text = button_Split.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
        }

        private void Button_Sqrt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Current.Text))
            {
                return;
            }
            textBox_Operation.Text = button_Sqrt.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
            Button_Result_Click(sender, e);
        }

        private void Button_Power2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Current.Text))
            {
                return;
            }
            textBox_Operation.Text = button_Power2.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
            Button_Result_Click(sender, e);
        }

        private void Button_OneSplitByX_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Current.Text))
            {
                return;
            }
            textBox_Operation.Text = button_OneSplitByX.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
            Button_Result_Click(sender, e);
        }

        private void Button_Percent_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Current.Text))
            {
                return;
            }
            textBox_Operation.Text = button_Percent.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
        }

        private void Button_Result_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Previous.Text))
            {
            }
            else if (String.IsNullOrEmpty(textBox_Current.Text))
            {
                var num = Convert.ToDouble(textBox_Previous.Text);
                double res;

                switch (textBox_Operation.Text)
                {
                    case "sqrt(x)":
                        res = Math.Sqrt(num);
                        listBox_Results.Items.Add("sqrt(" + num + ") = " + res);
                        break;
                    case "x^2":
                        res = Math.Pow(num, 2.0);
                        listBox_Results.Items.Add(num + "^2 = " + res);
                        break;
                    case "1/x":
                        res = 1.0 / num;
                        listBox_Results.Items.Add("1 / " + num + " = " + res);
                        break;
                }
            }
            else
            {
                var fnum = Convert.ToDouble(textBox_Previous.Text);
                var snum = Convert.ToDouble(textBox_Current.Text);
                var res = 0.0;

                switch (textBox_Operation.Text)
                {
                    case "+":
                        res = fnum + snum;
                        break;
                    case "-":
                        res = fnum - snum;
                        break;
                    case "*":
                        res = fnum * snum;
                        break;
                    case "/":
                        res = fnum / snum;
                        break;
                    case "%":
                        res = fnum / snum * 100;
                        break;
                }

                listBox_Results.Items.Add(textBox_Previous.Text + " " + textBox_Operation.Text + " " + textBox_Current.Text + " = " + res);                
            }
            Button_RemoveAll_Click(sender, e);
        }

        private void ListBox_Results_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Current.Text = listBox_Results.SelectedItem.ToString().Split(new char[] { ' ' }).Last();
        }

        private void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    Button_0_Click(sender, e);
                    break;
                case '1':
                    Button_1_Click(sender, e);
                    break;
                case '2':
                    Button_2_Click(sender, e);
                    break;
                case '3':
                    Button_3_Click(sender, e);
                    break;
                case '4':
                    Button_4_Click(sender, e);
                    break;
                case '5':
                    Button_5_Click(sender, e);
                    break;
                case '6':
                    Button_6_Click(sender, e);
                    break;
                case '7':
                    Button_7_Click(sender, e);
                    break;
                case '8':
                    Button_8_Click(sender, e);
                    break;
                case '9':
                    Button_9_Click(sender, e);
                    break;
                case '+':
                    Button_Add_Click(sender, e);
                    break;
                case '-':
                    Button_Minus_Click(sender, e);
                    break;
                case '*':
                    Button_Multiply_Click(sender, e);
                    break;
                case '/':
                    Button_Split_Click(sender, e);
                    break;
                case (char)8:
                    Button_RemoveOneNum_Click(sender, e);
                    break;
            }
        }

        private void Button_ChangeSigh_Click(object sender, EventArgs e)
        {
            if (textBox_Current.Text.First().Equals('-'))
            {
                textBox_Current.Text = textBox_Current.Text.Trim('-');
            }
            else
            {
                textBox_Current.Text = "-" + textBox_Current.Text;
            }
        }
    }
}
