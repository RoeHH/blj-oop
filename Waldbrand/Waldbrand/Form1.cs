using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waldbrand
{
    public partial class Form1 : Form
    {
        private Simulator _simulator;
        private Waldbestandteil[,] _waldKarte;
        private int _breite;

      
        public Form1()
        {
            InitializeComponent();
        }

        private void startSim_Click(object sender, EventArgs e)
        {
            _breite = (int)breiteInPut.Value;
            _waldKarte = new Waldbestandteil[(int)tiefeInPut.Value, (int)breiteInPut.Value];
            _simulator = new Simulator(_waldKarte, (int)entzündungInPut.Value, (int)wachstumInPut.Value, (int)breiteInPut.Value, (int)tiefeInPut.Value);
            printWald();
        }

        public void printWald()
        {
            while (true)
            {
                _simulator.Simulation();
                string temp = "";
                int inBreite = 1;
                foreach (Waldbestandteil waldstück in _waldKarte)
                {
                    if(waldstück.GetType() == typeof(Stein))
                        temp += "0";
                    if (waldstück.GetType() == typeof(Baum))
                    {
                        if (((Baum)waldstück).burningTime == 0)
                            temp += "B";
                        if (((Baum)waldstück).burningTime == 1)
                            temp += "F";
                        if (((Baum)waldstück).burningTime == 2)
                            temp += "f";
                    }
                    if (waldstück.GetType() == typeof(Humus))
                        temp += "_";
                    if (inBreite == _breite)
                    {
                        temp += "\r\n";
                        inBreite = 0;
                    }
                        
                    inBreite++;
                }
                outPut.Text = temp;
                Application.DoEvents();
                Thread.Sleep((int)delayValue.Value);
            }
            
        }

        private void wachstumInPut_ValueChanged(object sender, EventArgs e)
        {
            _simulator._wachstumsChance = (int)wachstumInPut.Value;
        }

        private void entzündungInPut_ValueChanged(object sender, EventArgs e)
        {
            _simulator._entzündungsChance = (int)entzündungInPut.Value;
        }

    }
}
