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
        public Form1()
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

        private void button_point_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Current.Text))
            {
                textBox_Current.Text += "0.";
            }
            else
            {
                textBox_Current.Text += ".";
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            textBox_Operation.Text = "+";
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
        }

        private void button_RemoveAll_Click(object sender, EventArgs e)
        {
            textBox_Current.Text = null;
            textBox_Operation.Text = null;
            textBox_Previous.Text = null;
        }
    }
}
