using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    class Tanne
    {

        private int stammbreite;
        private int stammhöhe;
        private int kronnenhoehe;
        private string zeichnung;

        public Tanne(int stb, int sth, int krh)
        {
            this.stammbreite = stb;
            this.stammhöhe = sth;
            this.kronnenhoehe = krh;
        }

        public string Zeichnung
        {
            get { return zeichnung; }
        }

        public void Zeichnen()
        {
            for(int i = 0; i < kronnenhoehe; i++)
                for(int j = 0; j < i * 2 + 1; j++)
                {
                    if (j == i * 2)
                    {
                        zeichnung += "*\r\n";
                    }
                    else
                    {
                        zeichnung += "*";
                    }
                }
            for(int i = 0; i < stammhöhe; i++)
                for(int j = 0; j < stammbreite; j++)
                {
                    if (j == stammbreite -1)
                    {
                        zeichnung += "*\r\n";
                    }
                    else
                    {
                        zeichnung += "*";
                    }
                }

        }
        

        /*
        public int Stammbreite
        {
            get { return stammbreite; }
            set { stammbreite = value; }
        }

        public int Stammhöhe
        {
            get { return stammhöhe; }
            set { stammhöhe = value; }
        }

        public int Kronnenhoehe
        {
            get { return kronnenhoehe; }
            set { kronnenhoehe = value; }
        }
        */
    }
}
