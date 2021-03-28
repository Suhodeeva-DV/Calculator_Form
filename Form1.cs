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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = "";
            znak = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool comma = false;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == ',')
                {
                    comma = true;
                    break;
                }
            }
            if (comma == false)
            {
                textBox1.Text += ",";
            }
        }

        //public object Calculator (double operand1, double)

        double operand1;
        double operand2;
        char operation;
        bool znak = true;

        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(textBox1.Text);
            label3.Text = operand1.ToString() + " + ";
            operation = '+';
            textBox1.Clear();
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(textBox1.Text);
            label3.Text = operand1.ToString() + " - ";
            operation = '-';
            textBox1.Clear();
            znak = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(textBox1.Text);
            label3.Text = operand1.ToString() + " * ";
            operation = '*';
            textBox1.Clear();
            znak = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(textBox1.Text);
            label3.Text = operand1.ToString() + " / ";
            operation = '/';
            textBox1.Clear();
            znak = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operand2 = double.Parse(textBox1.Text);
            label3.Text += operand2.ToString() + " = ";
            Calculator();
        }

        public void Calculator()
        {
            switch(operation)
            {
                case '+':
                    textBox1.Text = (operand1 + operand2).ToString();
                    break;
                case '-':
                    textBox1.Text = (operand1 - operand2).ToString();
                    break;
                case '*':
                    textBox1.Text = (operand1 * operand2).ToString();
                    break;
                case '/':
                    textBox1.Text = (operand1 / operand2).ToString();
                    break;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            text = text.Substring(0, text.Length - 1);
            textBox1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }
    }
}
