using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_MoveCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timerCar_Tick(object sender, EventArgs e)
        {
            picboxCar.Left += 5;
            if (picboxCar.Left >= 660)
            {
                timerCar.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerCar.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerCar.Enabled = false;
        }

        private void picboxCar_Click(object sender, EventArgs e)
        {

        }
    }
}
