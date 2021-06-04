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
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += "0"; 
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox_Current.Text += "9";
        }

        private void button_RemoveOneNum_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Current.Text))
            {

            }
            else
            {
                textBox_Current.Text = textBox_Current.Text.TrimEnd(new char[]
                { textBox_Current.Text.ElementAt(textBox_Current.Text.Length - 1) });
            }
            
        }

        private void button_RemoveOneElem_Click(object sender, EventArgs e)
        {
            textBox_Current.Text = textBox_Previous.Text;
            textBox_Operation.Text = null;
            textBox_Previous.Text = null;
        }

        private void button_Point_Click(object sender, EventArgs e)
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

        private void button_RemoveAll_Click(object sender, EventArgs e)
        {
            textBox_Current.Text = null;
            textBox_Operation.Text = null;
            textBox_Previous.Text = null;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            textBox_Operation.Text = button_Add.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
        }

        private void button_Minus_Click(object sender, EventArgs e)
        {
            textBox_Operation.Text = button_Minus.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {
            textBox_Operation.Text = button_Multiply.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
        }

        private void button_Split_Click(object sender, EventArgs e)
        {
            textBox_Operation.Text = button_Split.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
        }

        private void button_Sqrt_Click(object sender, EventArgs e)
        {
            textBox_Operation.Text = button_Sqrt.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
            button_Result_Click(sender, e);
        }

        private void button_Power2_Click(object sender, EventArgs e)
        {
            textBox_Operation.Text = button_Power2.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
            button_Result_Click(sender, e);
        }

        private void button_OneSplitByX_Click(object sender, EventArgs e)
        {
            textBox_Operation.Text = button_OneSplitByX.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
            button_Result_Click(sender, e);
        }

        private void button_Percent_Click(object sender, EventArgs e)
        {
            textBox_Operation.Text = button_Percent.Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Previous.Text))
            {
            }
            else if (String.IsNullOrEmpty(textBox_Current.Text))
            {
                var num = Convert.ToDouble(textBox_Previous.Text);
                var res = 0.0;

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
            button_RemoveAll_Click(sender, e);
        }

        private void listBox_Results_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Current.Text = listBox_Results.SelectedItem.ToString().Split(new char[] { ' ' }).Last();
        }

        private void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
