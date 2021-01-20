using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahlenspeicher
{
    public partial class Form1 : Form
    {
        private IZahlenspeicher<int> _zahlenspeicher = new Zahlenspeicher<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int number = int.Parse(inPut.Text);
            _zahlenspeicher.add(number);
            outPut.Text = $"Zahl {number} eingefügt";
        }

        private void get_Click(object sender, EventArgs e)
        {
            outPut.Text = _zahlenspeicher.get(ascend.Checked ? SortOrder.ASCENDING : SortOrder.DESCENDING);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            _zahlenspeicher.clear();
            outPut.Text = "Der Zahlenspeicher wurde geleert";
        }
    }
}
