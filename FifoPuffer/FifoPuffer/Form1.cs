﻿using System;
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
            bool temp = _fifo.Put(Convert.ToInt32(inPut.Value));
            if(!temp)
            {
                MessageBox.Show("Queueueue Full");
            }
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            string temp = _fifo.Get().ToString();
            if(temp=="1.5")
            {
                outPut.Text = "";
                MessageBox.Show("Queueueue Empty");
                return;
            }
            outPut.Text = temp;
        }

        private void getAllButton_Click(object sender, EventArgs e)
        {
            string temp = _fifo.GetAll();
            if(temp==null)
            {
                outPut.Text = "";
                MessageBox.Show("Queueueue Empty");
                return;
            }
            outPut.Text = temp;
        }
    }
}
