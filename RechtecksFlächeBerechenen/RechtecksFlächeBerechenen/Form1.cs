using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RechtecksFlächeBerechenen
{
    public partial class Form1 : Form
    {

        private Controller controller = new Controller();

        public Form1()
        {
            InitializeComponent();
        }


        private void InputBreite_TextChanged(object sender, EventArgs e)
        {
            string eingabe = InputBreite.Text;
            int breite = Convert.ToInt32(eingabe);
            controller.neueBreite(breite);
        }

        private void InputHöhe_TextChanged(object sender, EventArgs e)
        {
            string eingabe = InputHöhe.Text;
            int höhe = Convert.ToInt32(eingabe);
            controller.neueHöhe(höhe);
        }

        private void BerechnenButton_Click(object sender, EventArgs e)
        {
            this.Ausgabe.Text = controller.berechneFläche().ToString();
        }

        private void BeendenButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
