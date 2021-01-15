using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounter
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordTab wrdTb = new WordTab();
            Parser wrdCounter = new Parser(wrdTb);
            wrdCounter.Parse(inPut.Text);
            wrdTb.PrintTab(outPut);
        }
    }
}
