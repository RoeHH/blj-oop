using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErdeMond
{
    public partial class Form1 : Form
    {
        private Boolean indays;
        private double distanceEarthMoonInKM = 384000;
        private double speedInKMpH;

        public Form1()
        {
            InitializeComponent();
        }

        private void callculate_Click(object sender, EventArgs e)
        {
            double timeNeededInHours = this.distanceEarthMoonInKM / this.speedInKMpH;
            if (this.indays)
            {
                double timeNeededInDays = timeNeededInHours * 24;
                this.output.Text = timeNeededInDays.ToString() + " Days";
            }
            else
            {
                this.output.Text = timeNeededInHours.ToString() + " Hours";
            }
        }

        private void speed_TextChanged(object sender, EventArgs e)
        {
            string eingabe = speed.Text;
            this.speedInKMpH = Convert.ToDouble(eingabe);
        }

        private void inDays_CheckedChanged(object sender, EventArgs e)
        {
            if (inDays.Checked == true)
            {
                this.indays = true;
            }
        }

        private void inHours_CheckedChanged(object sender, EventArgs e)
        {
            if (inHours.Checked == true)
            {
                this.indays = false;
            }
        }

    }
}
