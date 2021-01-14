using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AutoSim
{

    class Auto
    {
        public string Marke { get; }
        public int PS { get; }
        public int AktueleGeschwindigkeit { get; private set; }
        public int AktuelerGang { get; private set; }
        public bool IstMotorGestartet { get; private set; }
        public bool bremst { get; private set; }
        public bool GibtGas { get; private set; }

        
        

        public override string ToString()
        {

            return Marke;
        }

        public Auto(string marke, int ps)
        {
            AktueleGeschwindigkeit = 100;
            this.Marke = marke;
            PS = ps;
        }
        public void StarteMotor()
        {
            IstMotorGestartet = true;
        }
        public void StopeMotor()
        {
            IstMotorGestartet = false;
        }
        public void GibGas()
        {

        }
        public void StopGas() { }
        public async void Bremse()
        {
            while (bremst || AktueleGeschwindigkeit > 0)
            {
                AktueleGeschwindigkeit -= 10;
            }
        }
        public void StopBremse()
        {
            bremst = false;
        }
        public void Hupe()
        {
            if (IstMotorGestartet)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"..\..\..\F1theme.wav");
                simpleSound.Play();
            }
        }

    }
}
