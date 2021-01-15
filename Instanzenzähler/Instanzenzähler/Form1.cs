using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instanzenzähler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void neu_Click(object sender, EventArgs e)
        {
            c cClass = c.getInstance();
            if (cClass == null)
                MessageBox.Show("No more Instances for you");
            outPut.Text = $"Anzahle Instanzen: {c.AmountInstances}";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            c.resetAmountInstances();
            outPut.Text = $"Anzahle Instanzen: {c.AmountInstances}";
        }
    }
}
