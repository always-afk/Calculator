using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.BusinessLogic;

namespace Calculator.Presentation
{
    public partial class StartupForm : Form
    {
        private const double Zero = 0.0;
        private const double One = 1.0;
        private const double Two = 2.0;
        private const double Three = 3.0;
        private const double Four = 4.0;
        private const double Five = 5.0;
        private const double Six = 6.0;
        private const double Seven = 7.0;
        private const double Eight = 8.0;
        private const double Nine = 9.0;


        private const int MaxLenght = 10;

        private IViewServices _view;
        

        public StartupForm(IViewServices logic)
        {
            InitializeComponent();
            _view = logic;
        }

        private void Button_0_Click(object sender, EventArgs e) => textBox_Current.Text += Zero;

        private void Button_1_Click(object sender, EventArgs e) => textBox_Current.Text += One;

        private void Button_2_Click(object sender, EventArgs e) => textBox_Current.Text += Two;

        private void Button_3_Click(object sender, EventArgs e) => textBox_Current.Text += Three;

        private void Button_4_Click(object sender, EventArgs e) => textBox_Current.Text += Four;

        private void Button_5_Click(object sender, EventArgs e) => textBox_Current.Text += Five;

        private void Button_6_Click(object sender, EventArgs e) => textBox_Current.Text += Six;

        private void Button_7_Click(object sender, EventArgs e) => textBox_Current.Text += Seven;

        private void Button_8_Click(object sender, EventArgs e) => textBox_Current.Text += Eight;

        private void Button_9_Click(object sender, EventArgs e) => textBox_Current.Text += Nine;

        private void Button_RemoveOneNum_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Current.Text))
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
            textBox_Current.Text = _view.PointLogic(textBox_Current.Text);
        }

        private void Button_RemoveAll_Click(object sender, EventArgs e)
        {
            textBox_Current.Text = null;
            textBox_Operation.Text = null;
            textBox_Previous.Text = null;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Current.Text))
            {
                Swap(sender);
                _view.CurrentOperation = Operations.Add;
            }
        }

        private void Button_Minus_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Current.Text))
            {
                Swap(sender);
                _view.CurrentOperation = Operations.Substract;
            }
        }

        private void Button_Multiply_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Current.Text))
            {
                Swap(sender);
                _view.CurrentOperation = Operations.Multiply;
            }
        }

        private void Button_Split_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Current.Text))
            {
                Swap(sender);
                _view.CurrentOperation = Operations.Split;
            }
        }

        private void Button_Sqrt_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Current.Text))
            {
                Swap(sender);
                _view.CurrentOperation = Operations.Sqrt;
                Button_Result_Click(sender, e);
            }
        }

        private void Button_Power2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Current.Text))
            {
                Swap(sender);
                _view.CurrentOperation = Operations.Pow2;
                Button_Result_Click(sender, e);
            }
        }

        private void Button_OneSplitByX_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Current.Text))
            {
                _view.CurrentOperation = Operations.Split;
                textBox_Previous.Text += 1.0;
                textBox_Operation.Text = button_Split.Text;
                Button_Result_Click(sender, e);
            }
        }

        private void Button_Percent_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Current.Text))
            {
                Swap(sender);
                _view.CurrentOperation = Operations.Percent;
            }
        }

        private void Button_Result_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if(Double.TryParse(textBox_Previous.Text, out num1) && Double.TryParse(textBox_Current.Text, out num2))
            {
                listBox_Results.Items.Add(_view.FindRes(num1, num2, textBox_Operation.Text));
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

        private void Swap(object sender)
        {
            textBox_Operation.Text = (sender as Button).Text;
            textBox_Previous.Text = textBox_Current.Text;
            textBox_Current.Text = null;
        }

        private void textBox_Current_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Current.Text.Length > MaxLenght)
            {
                if (textBox_Current.Text[1] == ',')
                {
                    if (textBox_Current.Text.Length - MaxLenght > 1)
                    {
                        textBox_Current.Text = textBox_Current.Text.Substring(textBox_Current.Text.Length - MaxLenght);
                    }
                }
                else
                {
                    textBox_Current.Text = textBox_Current.Text.Substring(textBox_Current.Text.Length - MaxLenght);
                }
            }
        }

        private void buttonSaveClick(object sender, EventArgs e)
        {
            List<string> notes = new List<string>();
            foreach (var el in listBox_Results.Items)
            {
                notes.Add(el.ToString());
            }
            _view.Save(notes);
            MessageBox.Show("Saved");
        }

        private void ButtonLoadClick(object sender, EventArgs e)
        {
            foreach (var el in _view.Load())
            {
                listBox_Results.Items.Add(el);
            }
            MessageBox.Show("Loaded");
        }
    }

}
