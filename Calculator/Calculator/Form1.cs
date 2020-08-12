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
        float operand1;
        float operand2;
        float result;
        char operat;
        Boolean operatorFlag;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operatorFlag = false;
            operand1 = 0;
            operand2 = 0;
            result = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Clear();
                txtLog.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length == 0)
            {
                txtDisplay.Text = txtDisplay.Text + "0";
                txtDisplay.Text = txtDisplay.Text + ".";
            }
            else if (txtDisplay.Text.Contains('.'))
            { }
            else
            txtDisplay.Text = txtDisplay.Text + ".";
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                if (txtDisplay.Text.Contains('-'))
                {
                    txtDisplay.Text = txtDisplay.Text.Replace("-", "");
                }
                else
                {
                    txtDisplay.Text = "-" + txtDisplay.Text;
                }
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (operatorFlag)
            {
                operand2 = float.Parse(txtDisplay.Text);
                operatorFlag = false;
                result = operand1 + operand2;
                txtLog.Text = txtLog.Text + txtDisplay.Text;
                txtDisplay.Text = result.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operand1 = float.Parse(txtDisplay.Text);
            operat = '+';
            operatorFlag = true;
            txtLog.Text = txtDisplay.Text + " + ";
            txtDisplay.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operand1 = float.Parse(txtDisplay.Text);
            operat = '-';
            operatorFlag = true;
            txtLog.Text = txtDisplay.Text + " - ";
            txtDisplay.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = float.Parse(txtDisplay.Text);
            operat = '*';
            operatorFlag = true;
            txtLog.Text = txtDisplay.Text + " x ";
            txtDisplay.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = float.Parse(txtDisplay.Text);
            operat = '/';
            operatorFlag = true;
            txtLog.Text = txtDisplay.Text + " ÷ ";
            txtDisplay.Clear();
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operand1 = float.Parse(txtDisplay.Text);
            operat = '%';
            operatorFlag = true;
            txtLog.Text = txtDisplay.Text + " % ";
            txtDisplay.Clear();
        }
    }
}
