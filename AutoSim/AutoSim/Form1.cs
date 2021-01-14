using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSim
{

    public partial class Form1 : Form
    {
        private Auto auto { set; get; }
       

        public Form1()
        {
            InitializeComponent();
            autoInput.Items.Add(new Auto("Porsche", 250));
            autoInput.Items.Add(new Auto("Opel", 90));
            autoInput.Items.Add(new Auto("Ferari", 370));
            autoInput.Items.Add(new Auto("Mclaren", 5000));
        }

        public void UpdateCounters()
        {
                GeschwindigkeitOutPut.Text = auto.AktueleGeschwindigkeit.ToString();
                auto.UpdateGang();
                GangOutPut.Text = auto.AktuelerGang.ToString();
        }
        

        private void key_Click(object sender, EventArgs e)
        {
            if (auto != null)
            {
                if (auto.IstMotorGestartet)
                {
                    auto.StopeMotor();
                    keyButton.Image = Image.FromFile("../../../autoAus.png");
                }
                else
                {
                    auto.StarteMotor();
                    keyButton.Image = Image.FromFile("../../../autoAn.png");
                }
                UpdateCounters();
            }

        }

        private void autoInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            auto = autoInput.SelectedItem as Auto;
            this.psOut.Text = auto.PS.ToString();
            if (auto.IstMotorGestartet)
            {
                keyButton.Image = Image.FromFile("../../../autoAn.png");
            }
            else
            {
                keyButton.Image = Image.FromFile("../../../autoAus.png");
            }
            UpdateCounters();

        }

        private void HuppeButton_Click(object sender, EventArgs e)
        {
            if (auto != null)
            {
                auto.Hupe();
                UpdateCounters();
            }
        }



        private void bremseButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (auto != null)
            {
                auto.Bremst = true;
                bremseButton.BackColor = System.Drawing.Color.Black;
                bremseButton.ForeColor = System.Drawing.Color.White;
                while (auto.Bremst)
                {
                    auto.Bremse();
                    UpdateCounters();
                    Application.DoEvents();
                    Thread.Sleep(200);
                }
                
            }
        }

        private void bremseButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (auto != null)
            {
                auto.Bremst = false;
                bremseButton.BackColor = System.Drawing.Color.White;
                bremseButton.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void gasButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (auto != null)
            {
                auto.GibtGas = true;
                bremseButton.BackColor = System.Drawing.Color.Black;
                bremseButton.ForeColor = System.Drawing.Color.White;
                while (auto.GibtGas)
                {
                    auto.GibGas();
                    UpdateCounters();
                    Application.DoEvents();
                    Thread.Sleep(100);
                }
            }
        }

        private void gasButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (auto != null)
            {
                auto.GibtGas = false;
                bremseButton.BackColor = System.Drawing.Color.White;
                bremseButton.ForeColor = System.Drawing.Color.Black;
            }
        }
    }
}
