using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_pictureViewer
{
    public partial class Form1 : Form
    {
        int number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            number += 1;
            if (number == 7)
                number = 1;
            string path = number.ToString() + ".jpg";
            picSample.ImageLocation = path;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            number -= 1;
            if (number == 0 || number == -1)
            {
                number = 6;
            }
            string path = number.ToString() + ".jpg";
            picSample.ImageLocation = path;
        }

        private void btnZoomIN_Click(object sender, EventArgs e)
        {
            picSample.Width += 4;
            picSample.Height += 3;
            picSample.Left = (this.Width - picSample.Width) / 2;
            picSample.Top = (this.Height - picSample.Height) / 2;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            picSample.Width -= 4;
            picSample.Height -= 3;
            picSample.Left = (this.Width - picSample.Width) / 2;
            picSample.Top = (this.Height - picSample.Height) / 2;
        }
    }
}
