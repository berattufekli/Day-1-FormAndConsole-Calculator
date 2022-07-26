using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.FormApp
{
    public partial class Form1 : Form
    {
        double num1, num2, result;

        string num1Str, num2Str, islem;

        private bool firstNumSelected = false;
        private bool secondNumSelected = false;

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                islem = "+";
                lbl_result.Text = num1Str + " " + islem;
                firstNumSelected = true;
            }
            else if (firstNumSelected && islem != "+" && !secondNumSelected)
            {
                islem = "+";
                lbl_result.Text = num1Str + " " + islem;
            }
            else if (firstNumSelected && islem == "+" && secondNumSelected)
            {
                num1 = Convert.ToDouble(num1Str);
                num2 = Convert.ToDouble(num2Str);
                result = Helper.Plus(num1, num2);

                lbl_previousResult.Text = num1Str + " " + islem + " " + num2Str + " = " + result.ToString();

                num1Str = result.ToString();
                num2Str = "";

                lbl_result.Text = num1Str + " " + islem;
                secondNumSelected = false;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            firstNumSelected = false;
            secondNumSelected = false;
            num1Str = null;
            num2Str = null;
            result = 0;
            num1 = 0;
            num2 = 0;
            lbl_result.Text = "";
            lbl_previousResult.Text = "Cleaned";
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected)
            {
                islem = "*";
                lbl_result.Text = num1Str + " " + islem;
                firstNumSelected = true;
            }
            else if (firstNumSelected && islem != "*" && !secondNumSelected)
            {
                islem = "*";
                lbl_result.Text = num1Str + " " + islem;
            }
            else if (firstNumSelected && islem == "*" && secondNumSelected)
            {
                num1 = Convert.ToDouble(num1Str);
                num2 = Convert.ToDouble(num2Str);
                result = Helper.Multiply(num1, num2);

                lbl_previousResult.Text = num1Str + " " + islem + " " + num2Str + " = " + result.ToString();

                num1Str = result.ToString();
                num2Str = "";

                lbl_result.Text = num1Str + " " + islem;
                secondNumSelected = false;
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected)
            {
                islem = "/";
                lbl_result.Text = num1Str + " " + islem;
                firstNumSelected = true;
            }
            else if (firstNumSelected && islem != "/" && !secondNumSelected)
            {
                islem = "/";
                lbl_result.Text = num1Str + " " + islem;
            }
            else if (firstNumSelected && islem == "/" && secondNumSelected)
            {
                num1 = Convert.ToDouble(num1Str);
                num2 = Convert.ToDouble(num2Str);
                result = Helper.Divide(num1, num2);

                lbl_previousResult.Text = num1Str + " " + islem + " " + num2Str + " = " + result.ToString();

                num1Str = result.ToString();
                num2Str = "";

                lbl_result.Text = num1Str + " " + islem;
                secondNumSelected = false;
            }
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            if (firstNumSelected && islem != null && secondNumSelected)
            {
                num1 = Convert.ToDouble(num1Str);
                num2 = Convert.ToDouble(num2Str);

                if(islem == "+")
                {
                    result = Helper.Plus(num1, num2);
                }
                else if (islem == "-")
                {
                    result = Helper.Minus(num1, num2);
                }
                else if (islem == "*")
                {
                    result = Helper.Multiply(num1, num2);
                }
                else if(islem == "/")
                {
                    result = Helper.Divide(num1, num2);
                }
                else if(islem == "^")
                {
                    result = Helper.Pow(num1, num2);
                }

                lbl_previousResult.Text = num1Str + " " + islem + " " + num2Str + " = " + result.ToString();

                num1Str = result.ToString();
                num2Str = "";

                lbl_result.Text = num1Str;
                secondNumSelected = false;
                islem = null;
            }
            else if(islem == "√")
            {
                num1 = Convert.ToDouble(num1Str);
                result = Helper.Sqrt(num1);

                lbl_previousResult.Text = islem + num1Str + " = " + result.ToString();

                num1Str = result.ToString();
                num2Str = "";

                lbl_result.Text = num1Str;
                secondNumSelected = false;
                islem = null;
            }
        }

        private void btn_negative_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected && islem == null)
            {
                num1Str = (Convert.ToDouble(num1Str) * -1).ToString();
                lbl_result.Text = num1Str;
            }
            else if (firstNumSelected)
            {
                num1Str = (Convert.ToDouble(num1Str) * -1).ToString();
                lbl_result.Text = num1Str;
            }
            else
            {
                num2Str = (Convert.ToDouble(num2Str) * -1).ToString();
                lbl_result.Text = num1Str + " " + islem + " " + num2Str;
            }
        }

        private void btn_comma_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected && islem == null)
            {
                num1Str += ","; 
                lbl_result.Text = num1Str;
            }
            else
            {
                num2Str += ",";
                lbl_result.Text = num1Str + " " + islem + " " + num2Str;
            }
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected )
            {
                islem = "^";
                lbl_result.Text = num1Str + " " + islem;
                firstNumSelected = true;
            }
            else if(firstNumSelected && islem != "^" && !secondNumSelected)
            {
                islem = "^";
                lbl_result.Text = num1Str + " " + islem;
            }
            
        }

        private void btn_squareRoot_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected)
            {
                islem = "√";
                lbl_result.Text = islem + num1Str;
            }
            else if(firstNumSelected && islem != "√" && !secondNumSelected)
            {
                islem = "√";
                lbl_result.Text = islem + num1Str;
            } 
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected)
            {
                islem = "-";
                lbl_result.Text = num1Str + " " + islem;
                firstNumSelected = true;
            }
            else if (firstNumSelected && islem != "-" && !secondNumSelected)
            {
                islem = "-";
                lbl_result.Text = num1Str + " " + islem;
            }
            else if (firstNumSelected && islem == "-" && secondNumSelected)
            {
                num1 = Convert.ToDouble(num1Str);
                num2 = Convert.ToDouble(num2Str);
                result = Helper.Minus(num1, num2);

                lbl_previousResult.Text = num1Str + " " + islem + " " + num2Str + " = " + result.ToString();

                num1Str = result.ToString();
                num2Str = "";

                lbl_result.Text = num1Str + " " + islem;
                secondNumSelected = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                num1Str += 0;

                if (islem == "√")
                {
                    lbl_result.Text = islem + num1Str;
                }
                else
                {
                    lbl_result.Text = num1Str;
                }
            }
            else
            {
                num2Str += 0;
                lbl_result.Text = num1Str + " " + islem + " " + num2Str;
                secondNumSelected = true;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                num1Str += 1;
                if (islem == "√")
                {
                    lbl_result.Text = islem + num1Str;
                }
                else
                {
                    lbl_result.Text = num1Str;
                }
            }
            else
            {
                num2Str += 1;
                lbl_result.Text = num1Str + " " + islem + " " + num2Str;
                secondNumSelected = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                num1Str += 2;
                if (islem == "√")
                {
                    lbl_result.Text = islem + num1Str;
                }
                else
                {
                    lbl_result.Text = num1Str;
                }
            }
            else
            {
                num2Str += 2;
                lbl_result.Text = num1Str + " " + islem + " " + num2Str;
                secondNumSelected = true;
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                num1Str += 3;
                if (islem == "√")
                {
                    lbl_result.Text = islem + num1Str;
                }
                else
                {
                    lbl_result.Text = num1Str;
                }
            }
            else
            {
                num2Str += 3;
                lbl_result.Text = num1Str + " " + islem + " " + num2Str;
                secondNumSelected = true;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                num1Str += 4;
                if (islem == "√")
                {
                    lbl_result.Text = islem + num1Str;
                }
                else
                {
                    lbl_result.Text = num1Str;
                }
            }
            else
            {
                num2Str += 4;
                lbl_result.Text = num1Str + " " + islem + " " + num2Str;
                secondNumSelected = true;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                num1Str += 5;
                if (islem == "√")
                {
                    lbl_result.Text = islem + num1Str;
                }
                else
                {
                    lbl_result.Text = num1Str;
                }
            }
            else
            {
                num2Str += 5;
                lbl_result.Text = num1Str + " " + islem + " " + num2Str;
                secondNumSelected = true;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                num1Str += 6;
                if (islem == "√")
                {
                    lbl_result.Text = islem + num1Str;
                }
                else
                {
                    lbl_result.Text = num1Str;
                }
            }
            else
            {
                num2Str += 6;
                lbl_result.Text = num1Str + " " + islem + " " + num2Str;
                secondNumSelected = true;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                num1Str += 7;
                if (islem == "√")
                {
                    lbl_result.Text = islem + num1Str;
                }
                else
                {
                    lbl_result.Text = num1Str;
                }
            }
            else
            {
                num2Str += 7;
                lbl_result.Text = num1Str + " " + islem + " " + num2Str;
                secondNumSelected = true;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                num1Str += 8;
                if (islem == "√")
                {
                    lbl_result.Text = islem + num1Str;
                }
                else
                {
                    lbl_result.Text = num1Str;
                }
            }
            else
            {
                num2Str += 8;
                lbl_result.Text = num1Str + " " + islem + " " + num2Str;
                secondNumSelected = true;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!firstNumSelected || islem == null)
            {
                num1Str += 9;
                if (islem == "√")
                {
                    lbl_result.Text = islem + num1Str;
                }
                else
                {
                    lbl_result.Text = num1Str;
                }
            }
            else
            {
                num2Str += 9;
                lbl_result.Text = num1Str + " " + islem + " " + num2Str;
                secondNumSelected = true;
            }
        }
    }
}
