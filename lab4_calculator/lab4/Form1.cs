using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnmultiple_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(txtnum1.Text);
            double number2 = double.Parse(txtnum2.Text);
            double result = number1 * number2;
            txtnum3.Text = result.ToString();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(txtnum1.Text);
            double number2 = double.Parse(txtnum2.Text);
            double result = number1 / number2;
            txtnum3.Text = result.ToString();
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(txtnum1.Text);
            double number2 = double.Parse(txtnum2.Text);
            double result = number1 + number2;
            txtnum3.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(txtnum1.Text);
            double number2 = double.Parse(txtnum2.Text);
            double result = number1 - number2;
            txtnum3.Text = result.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtnum3.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
