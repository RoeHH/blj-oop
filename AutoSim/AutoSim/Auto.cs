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
        public bool Bremst { get;  set; }
        public bool GibtGas { get; set; }
        public int MaxSpeed { get; private set; }
        public int Beschleunigung { get; private set; }

        public Auto(string marke, int ps)
        {
            AktueleGeschwindigkeit = 0;
            this.Marke = marke;
            PS = ps;
            MaxSpeed = ps / 2 * 3;
            Beschleunigung = ps / 20;
        }

        public override string ToString()
        {
            return Marke;
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
            if(!IstMotorGestartet)
                return;
            if(AktueleGeschwindigkeit < MaxSpeed)
                AktueleGeschwindigkeit += Beschleunigung;
        }
        public void Bremse()
        {
            if(AktueleGeschwindigkeit >= 0)
            {
            AktueleGeschwindigkeit -= 10;
            }
            else
            {
            AktuelerGang = 0;
            }
        }
        public void Hupe()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"..\..\..\F1theme.wav");
            simpleSound.Play();
        }
        /*
        public void UpdateGang()
        {
            if(AktueleGeschwindigkeit == 0)
            {
                AktuelerGang = 1;
            }
            int temp = (int)Math.Ceiling((double)(AktueleGeschwindigkeit / 10));
            if(temp == 5 || temp == 6 || temp == 7){
                AktuelerGang = 5;
            }
            else if(temp == 8||temp == 9||temp == 10)
            {
                AktuelerGang = 6;
            }
            else if(temp < 11)
            {
                AktuelerGang = 6;
            }
            
        }
        */

    }
}
