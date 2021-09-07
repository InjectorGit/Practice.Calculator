using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char sign; // Знак
        string firstNumber; // Первое число
        string secondNumber; // Второе число
        bool check_sign = false;

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += ',';
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            firstNumber = null;
            secondNumber = null;
            check_sign = false;
        }
        public void calculate()
        {
            int i = firstNumber.Length + 1;
            while (i < textBox1.Text.Length)
            {
                secondNumber += textBox1.Text[i]; 
                i++;
            }
            if (sign == '+') { textBox1.Text = Convert.ToString(Convert.ToDouble(firstNumber) + Convert.ToDouble(secondNumber)); }
            if (sign == '-') { textBox1.Text = Convert.ToString(Convert.ToDouble(firstNumber) - Convert.ToDouble(secondNumber)); }
            if (sign == '*') { textBox1.Text = Convert.ToString(Convert.ToDouble(firstNumber) * Convert.ToDouble(secondNumber)); }
            if (sign == '/') { textBox1.Text = Convert.ToString(Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber)); }
            if (sign == 'M')
            {
                if (Convert.ToDouble(firstNumber) > Convert.ToDouble(secondNumber))
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(secondNumber));
                }
                else if ((Convert.ToDouble(firstNumber) < Convert.ToDouble(secondNumber)))
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(firstNumber));
                }
                else if (Convert.ToDouble(firstNumber) == Convert.ToDouble(secondNumber))
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(firstNumber));
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check_sign) { calculate(); }
            sign = '+';
            firstNumber = textBox1.Text;
            textBox1.Text += "+";
            check_sign = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (check_sign) { calculate(); }
            sign = '*';
            firstNumber = textBox1.Text;
            textBox1.Text += "*";
            check_sign = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (check_sign) { calculate(); }
            sign = '-';
            firstNumber = textBox1.Text;
            textBox1.Text += "-";
            check_sign = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (check_sign) { calculate(); }
            sign = '/';
            firstNumber = textBox1.Text;
            textBox1.Text += "/";
            check_sign = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculate();
            check_sign = false;
            secondNumber = null;
            check_sign = false;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (check_sign) { calculate(); }
            sign = 'M';
            firstNumber= textBox1.Text;
            textBox1.Text += "`";
            check_sign = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
    }
}
