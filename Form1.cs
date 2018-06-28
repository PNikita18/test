using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondCalk
{
    public partial class Form1 : Form
    {
        double a, b, mem;
        string c;
        public Form1()
        { 
            InitializeComponent();
        }

        private void Button12_Click(object sender, EventArgs e) => textBox1.Clear();

        private void button1_Click(object sender, EventArgs e) => textBox1.Text += "7";

        private void button2_Click(object sender, EventArgs e) => textBox1.Text += "8";

        private void button7_Click(object sender, EventArgs e) => textBox1.Text += "9";

        private void button4_Click(object sender, EventArgs e) => textBox1.Text += "4";

        private void button3_Click(object sender, EventArgs e) => textBox1.Text += "5";

        private void button8_Click(object sender, EventArgs e) => textBox1.Text += "6";

        private void button6_Click(object sender, EventArgs e) => textBox1.Text += "1";

        private void button5_Click(object sender, EventArgs e) => textBox1.Text += "2";

        private void button9_Click(object sender, EventArgs e) => textBox1.Text += "3";

        private void button10_Click(object sender, EventArgs e) => textBox1.Text += "0";

        private void button11_Click(object sender, EventArgs e) => textBox1.Text += ",";

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = "plus";
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = "minus";
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = "umnozhenie";
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = "delenie";
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = "cos";
            textBox1.Text = Convert.ToString(Math.Cos(a));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = "sin";
            textBox1.Text = Convert.ToString(Math.Sin(a));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = "stepen";
            textBox1.Clear();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            mem = Convert.ToDouble(textBox2.Text);
            c = "Mminus";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            mem = Convert.ToDouble(textBox2.Text);
            c = "Mplus";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            switch (c)
            {
                case "plus":
                    textBox1.Text = Convert.ToString(a + b);
                    break;
                case "minus":
                    textBox1.Text = Convert.ToString(a - b);
                    break;
                case "umnozhenie":
                    textBox1.Text = Convert.ToString(a * b);
                    break;
                case "delenie":
                    textBox1.Text = Convert.ToString(a / b);
                    break;
                case "stepen":
                    textBox1.Text = Convert.ToString(Math.Pow(a,b));
                    break;
                case "Mminus":
                    textBox2.Text = Convert.ToString(a - b);
                    break;
                case "Mplus":
                    textBox2.Text = Convert.ToString(a + b);
                    break;
            };
        }
    }
}
