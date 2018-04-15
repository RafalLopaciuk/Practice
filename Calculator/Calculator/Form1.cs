using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Models;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(numericUpDown1.Value);
            double b = Convert.ToDouble(numericUpDown2.Value);
            Couple action = new Couple(a, b);
            textBox1.Text = action.AddResult().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(numericUpDown1.Value);
            double b = Convert.ToDouble(numericUpDown2.Value);
            Couple action = new Couple(a, b);
            textBox1.Text = action.SubResult().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(numericUpDown1.Value);
            double b = Convert.ToDouble(numericUpDown2.Value);
            Couple action = new Couple(a, b);
            textBox1.Text = action.MulResult().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(numericUpDown1.Value);
            double b = Convert.ToDouble(numericUpDown2.Value);
            Couple action = new Couple(a, b);
            textBox1.Text = action.DivResult().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(numericUpDown1.Value);
            double b = Convert.ToDouble(numericUpDown2.Value);
            Couple action = new Couple(a, b);
            textBox1.Text = action.ModResult().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
