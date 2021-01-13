using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifoPuffer
{
    public partial class Form1 : Form
    {

        private FIFO _fifo = new FIFO(2);

        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            _fifo = new FIFO((int)sizeInPut.Value);
        }

        private void putButton_Click(object sender, EventArgs e)
        {
            _fifo.Put(Convert.ToInt32(inPut.Value));
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            outPut.Text = _fifo.Get().ToString();
        }

        private void getAllButton_Click(object sender, EventArgs e)
        {
            outPut.Text = _fifo.GetAll();
        }
    }
}
