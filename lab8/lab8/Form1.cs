using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
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

        private void picSample_Click(object sender, EventArgs e)
        {

        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialogAvatar.ShowDialog();
            OpenFileDialogAvatar.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if(OpenFileDialogAvatar.ShowDialog() == DialogResult.OK)
                picSample.ImageLocation = OpenFileDialogAvatar.FileName;
        }
    }
}
