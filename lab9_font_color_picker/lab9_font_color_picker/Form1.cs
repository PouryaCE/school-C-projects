using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9_font_color_picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtboxSample.ForeColor = colorDialog1.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtboxSample.Font = fontDialog1.Font;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "IMAGE FILES(*.jpg;*.jpeg)|*.jpg;*.jpeg";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
                picboxSample.ImageLocation = openFileDialog1.FileName;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
