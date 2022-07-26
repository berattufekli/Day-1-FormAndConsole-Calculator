using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.AlternateForm
{
    public partial class Form1 : Form
    {
        double no1, no2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(num1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                num1.Text = num1.Text.Remove(num1.Text.Length - 1);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            op.Text = "";
            lbl_result.Text = "";
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(num2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                num2.Text = num2.Text.Remove(num2.Text.Length - 1);
            }
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {   if(op.Text == "√")
            {
                no1 = Convert.ToDouble(num1.Text);
                result = Helper.Sqrt(no1);
                lbl_result.Text = result.ToString();
            }
            if(num1.Text != null && num2.Text != null && op.Text != null)
            {
                no1 = Convert.ToDouble(num1.Text);
                no2 = Convert.ToDouble(num2.Text);

                if (op.Text == "+")
                {
                    result = Helper.Plus(no1, no2);
                }
                else if (op.Text == "-")
                {
                    result = Helper.Minus(no1, no2);
                }
                else if (op.Text == "*")
                {
                    result = Helper.Multiply(no1, no2);
                }
                else if (op.Text == "/")
                {
                    result = Helper.Divide(no1, no2);
                }
                else if (op.Text == "^")
                {
                    result = Helper.Pow(no1, no2);
                }

                lbl_result.Text = result.ToString();
            }
            else
            {
                if(num1.Text == null)
                {
                    MessageBox.Show("num1 cannot be empty.");
                    num1.Focus();
                }
                else if(num2.Text == null)
                {
                    MessageBox.Show("num2 cannot be empty");
                    num2.Focus();
                }
                else if (op.Text == null) 
                {
                    MessageBox.Show("operator cannot be empty");
                    op.Focus();
                }
            }
        }
    }
}
