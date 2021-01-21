using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waldbrand
{
    class Wald
    {
        public Random _random { get; set; } = new Random();
        private Waldbestandteil[,] _waldKarte;
        private int _breite, _tiefe;

        public Wald(Waldbestandteil[,] waldKarte, int breite, int tiefe)
        {
            _waldKarte = waldKarte;
            _breite = breite;
            _tiefe = tiefe;
            erstelleWald();
        }
        private void erstelleWald()
        {
            int inBreite = 0;
            int inTiefe = 0;
            int i = 0;
            foreach (Waldbestandteil waldstück in _waldKarte)
            {
                _waldKarte[inTiefe, inBreite] = null;
                if (inBreite == _breite - 1)
                {
                    inTiefe++;
                    inBreite = 0;
                }
                else
                {
                    inBreite++;
                }
                i++;
            }
            inBreite = 0;
            inTiefe = 0;
            i = 0;
            foreach (Waldbestandteil waldstück in _waldKarte)
            {

                //Monitoring der Zahlen
                //Console.WriteLine($"{inTiefe} , {inBreite}:  {i}");
                
                //Random Waldbestandteile
                int genRand = _random.Next(1,10);
                
                switch (genRand)
                {
                    case 1:
                        _waldKarte[inTiefe, inBreite] = new Stein();
                        break;
                    case 2:
                    case 3:
                    case 4:
                        _waldKarte[inTiefe, inBreite] = new Humus();
                        break;
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        _waldKarte[inTiefe, inBreite] = new Baum();
                        break;
                }

                //Zähler
                if (inBreite == _breite - 1)
                {
                    inTiefe++;
                    inBreite = 0;
                }
                else
                {
                    inBreite++;
                }
                i++;
            }
            
        }
        
    }
}
