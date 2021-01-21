using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waldbrand
{
    class Simulator
    {
        public Random _random { get; set; } = new Random();
        private Waldbestandteil[,] _waldKarte;
        private Wald _wald;
        public int _entzündungsChance { get; set; }
        public int _wachstumsChance { get; set; }
        private int _breite;
        private int _tiefe;

        public Simulator(Waldbestandteil[,] waldKarte, int entzündungsChance, int wachstumsChance, int breite, int tiefe)
        {
            _entzündungsChance = entzündungsChance;
            _wachstumsChance = wachstumsChance;
            _breite = breite;
            _tiefe = tiefe;
            _waldKarte = waldKarte;
            _wald = new Wald(_waldKarte, breite, tiefe);
        }

        public void Simulation()
        {
            int inBreite = 0;
            int inTiefe = 0;
            int lit = 0;
            int genRand;
            foreach (Waldbestandteil waldstück in _waldKarte)
            {
                //Monitoring der Zahlen
                //Console.WriteLine($"{inTiefe} , {inBreite}:  {lit}");

                if(!waldstück.gotChanged|| waldstück.GetType() != typeof(Stein))
                {
                    genRand = _random.Next(1, 100);
                    if (waldstück.GetType() == typeof(Baum))
                    {
                        if (((Baum)waldstück).burningTime == 0)
                        {
                            if (genRand < _entzündungsChance)
                                (_waldKarte[inTiefe, inBreite] as Baum).burningTime = 1;
                        }
                        else if(((Baum)waldstück).burningTime == 1)
                        {
                            (_waldKarte[inTiefe, inBreite] as Baum).burningTime = 2;
                            if(inTiefe - 1 > 0)
                            {
                                if(_waldKarte[inTiefe - 1, inBreite].GetType() == typeof(Baum) && (_waldKarte[inTiefe - 1, inBreite] as Baum).burningTime == 0)
                                {
                                    (_waldKarte[inTiefe - 1, inBreite] as Baum).burningTime = 1;
                                }
                            }
                            else if(inBreite - 1 > 0)
                            {
                                if (_waldKarte[inTiefe, inBreite - 1].GetType() == typeof(Baum) && (_waldKarte[inTiefe, inBreite - 1] as Baum).burningTime == 0)
                                {
                                    (_waldKarte[inTiefe, inBreite - 1] as Baum).burningTime = 1;
                                }
                            }
                            else if (inTiefe + 1 != _tiefe)
                            {
                                if (_waldKarte[inTiefe + 1, inBreite].GetType() == typeof(Baum) && (_waldKarte[inTiefe + 1, inBreite] as Baum).burningTime == 0)
                                {
                                    (_waldKarte[inTiefe + 1, inBreite] as Baum).burningTime = 1;
                                }
                            }
                            else if (inBreite + 1 != _breite)
                            {
                                if (_waldKarte[inTiefe, inBreite + 1].GetType() == typeof(Baum) && (_waldKarte[inTiefe, inBreite + 1] as Baum).burningTime == 0)
                                {
                                    (_waldKarte[inTiefe, inBreite + 1] as Baum).burningTime = 1;
                                }
                            }
                        }
                        else if(((Baum)waldstück).burningTime == 2)
                        {
                            _waldKarte[inTiefe, inBreite] = new Humus();
                        }
                    }
                    else if(waldstück.GetType() == typeof(Humus))
                    {
                        if (genRand < _wachstumsChance)
                            _waldKarte[inTiefe, inBreite] = new Baum();
                    }
                    _waldKarte[inTiefe, inBreite].gotChanged = true;
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
                lit++;
            }
        }
    }
}
