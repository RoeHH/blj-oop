using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlterRechner
{
    enum  UOM
        {
            Years,
            Months,
            Days,
            Hours,
            Minutes,
            Seconds
        }

    public partial class Form1 : Form
    {

        private UOM uom;
        private DateTime date;
        private int ageInDays;
        private const double ApproxDaysPerMonth = 30.4375;
        private const double ApproxDaysPerYear = 365.25;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            this.date = dateTimePicker.Value;
            DateTime today = DateTime.Today;
            this.ageInDays = (today - this.date).Days + 1;
            switch (uom)
            {
                case UOM.Years:
                    this.ageOutput.Text = ((this.ageInDays / ApproxDaysPerYear).ToString())+" Jahre";
                    break;
                case UOM.Months:
                    this.ageOutput.Text = ((this.ageInDays / ApproxDaysPerMonth).ToString())+" Monate";
                    break;
                case UOM.Days:
                    this.ageOutput.Text = (this.ageInDays.ToString())+" Tage";
                    break;
                case UOM.Hours:
                    this.ageOutput.Text = ((this.ageInDays * 24).ToString())+" Stunden";
                    break;
                case UOM.Minutes:
                    this.ageOutput.Text = ((this.ageInDays * 1440).ToString())+" Minuten";
                    break;
                case UOM.Seconds:
                    this.ageOutput.Text = ((this.ageInDays * 86400).ToString())+" Sekunden";
                    break;
            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.date = dateTimePicker.Value;
        }

        private void Years_CheckedChanged(object sender, EventArgs e)
        {
            if (Years.Checked == true)
            {
                uom = UOM.Years;
            }
        }

        private void Months_CheckedChanged(object sender, EventArgs e)
        {
            if (Months.Checked == true)
            {
                uom = UOM.Months;
            }
        }

        private void Days_CheckedChanged(object sender, EventArgs e)
        {
            if (Days.Checked == true)
            {
                uom = UOM.Days;
            }
        }

        private void Hours_CheckedChanged(object sender, EventArgs e)
        {
            if (Hours.Checked == true)
            {
                uom = UOM.Hours;
            }
        }

        private void minutes_CheckedChanged(object sender, EventArgs e)
        {
            if (minutes.Checked == true)
            {
                uom = UOM.Minutes;
            }
        }

        private void seconds_CheckedChanged(object sender, EventArgs e)
        {
            if (seconds.Checked == true)
            {
                uom = UOM.Seconds;
            }
        }
    }
}
