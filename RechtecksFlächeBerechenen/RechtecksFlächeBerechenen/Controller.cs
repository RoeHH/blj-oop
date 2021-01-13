using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechtecksFlächeBerechenen
{
    class Controller
    {
        private int höhe;
        private int breite;

        public void neueHöhe(int höhe)
        {
            this.höhe = höhe;
        }

        public void neueBreite(int breite)
        {
            this.breite = breite;
        }

        public int berechneFläche()
        {
            return this.breite * this.höhe;
        }
    }
}
