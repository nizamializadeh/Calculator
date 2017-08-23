using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "   ";
        bool a = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn(object sender, EventArgs e)
        {
            if ((textBox1.Text=="0")||(a))
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text +=button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void operators(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            a = true;
            Button b = (Button)sender;
            textBox1.Text += b.Text;
            operation = b.Text;

          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textBox1.Text = (value + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            value = 0;

        }
    }
}
