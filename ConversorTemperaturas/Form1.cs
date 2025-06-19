using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorTemperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(textBox1.Text);
            double f = (k - 273.15) * 1.8 + 32;
            textBox2.Text = f.ToString("F2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(textBox1.Text);
            double c = k - 273.15;
            textBox2.Text = c.ToString("F2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox1.Text);
            double k = c * 1.8 + 32;
            textBox2.Text = k.ToString("F2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox1.Text);
            double k = c + 273.15;
            textBox2.Text = k.ToString("F2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBox1.Text);
            double k = (f - 32) * 5 / 9 + 273.15;
            textBox2.Text = k.ToString("F2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBox1.Text);
            double c = (f - 32) / 1.8;
            textBox2.Text = c.ToString("F2");
        }
    }
}
