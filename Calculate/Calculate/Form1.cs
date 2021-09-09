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
        double firstValue; // Первое число
        double secondValue; // Второе число
        double result;
        int count;

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
        }

        private void button5_Click(object sender, EventArgs e) //+
        {
            firstValue = Double.Parse(textBox1.Text);
            textBox1.Text += '+';
            textBox1.Clear();
         
            count = 1;
        }
        private void button13_Click(object sender, EventArgs e) //*
        {
            firstValue = Double.Parse(textBox1.Text);
            textBox1.Text += '+';
            textBox1.Clear();
            count = 4;
        }

        private void button9_Click(object sender, EventArgs e) //-
        {
            firstValue = Double.Parse(textBox1.Text);
            textBox1.Text += '-';
            textBox1.Clear();
            count = 2;
        }

        private void button17_Click(object sender, EventArgs e) // /
        {
            firstValue = Double.Parse(textBox1.Text);
            textBox1.Text += '/';
            textBox1.Clear();
            count=3;
        }

        private void button4_Click(object sender, EventArgs e) // =
        {
           
            if (textBox1.Text != "")
            {
                secondValue = Double.Parse(textBox1.Text);
                calc calculator = ClassFactoryMethod.calcMethod(count);
                result = calculator.Calculate(firstValue, secondValue);
                textBox1.Text = Convert.ToString(result);
            }
        }

        private void button18_Click(object sender, EventArgs e) //  MINIMUM
        {
            firstValue = Double.Parse(textBox1.Text);
            textBox1.Text += '%';
            textBox1.Clear();
            count = 5;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
    }
}
