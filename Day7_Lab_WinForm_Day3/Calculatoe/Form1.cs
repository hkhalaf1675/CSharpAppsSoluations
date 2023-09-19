using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
        }

        List<char> inputs = new List<char>();
        // method to save click and set the values of buttons to text box
        public void SetBtnValueOnTextBox(char ch)
        {
            inputs.Add(ch);
            txtResult.Text = txtResult.Text + ch;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('0');
        }
        private void btn1_Click_1(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('1');
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('2');
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('3');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('4');
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('5');
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('6');
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('7');
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('8');
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('9');
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('.');
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('+');
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('-');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('*');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            SetBtnValueOnTextBox('/');
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string num1 = null;
            string num2 = null;
            char? sign = null;
            foreach(char ch in inputs)
            {
                if ((ch == '+' || ch == '-' || ch == '*' || ch == '/') && num2 != null)
                {
                    switch (sign)
                    {
                        case '+':
                            num1 = (double.Parse(num1) + double.Parse(num2)).ToString();
                            break;
                        case '-':
                            num1 = (double.Parse(num1) - double.Parse(num2)).ToString();
                            break;
                        case '*':
                            num1 = (double.Parse(num1) * double.Parse(num2)).ToString();
                            break;
                        case '/':
                            num1 = (double.Parse(num1) / double.Parse(num2)).ToString();
                            break;
                    }
                    num2 = null;
                }
                if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
                {
                    sign = ch;
                    continue;
                }
                if (sign != null)
                {
                    if (num2 == null)
                        num2 = ch.ToString();
                    else
                        num2 = num2 + ch.ToString();
                }
                if (num2 == null)
                {
                    if (num1 == null)
                        num1 = ch.ToString();
                    else
                        num1 = num1 + ch.ToString();
                }
            }
            switch (sign)
            {
                case '+':
                    num1 = (double.Parse(num1) + double.Parse(num2)).ToString();
                    break;
                case '-':
                    num1 = (double.Parse(num1) - double.Parse(num2)).ToString();
                    break;
                case '*':
                    num1 = (double.Parse(num1) * double.Parse(num2)).ToString();
                    break;
                case '/':
                    num1 = (double.Parse(num1) / double.Parse(num2)).ToString();
                    break;
            }
            txtResult.Text = num1;
        }
    }

    
}
