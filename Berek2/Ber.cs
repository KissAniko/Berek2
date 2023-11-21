using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek2
{
    internal class Ber
    {
        string nev;
        bool nem;       // nő = true, false = férfi
        string reszleg;
        int belepes;
        int dolgozoBer;

        public Ber(string sor)
        {
            string[] mezok = sor.Split(';');
            this.nev = mezok[0];
            this.nem = mezok[1] == "nő";
            this.reszleg = mezok[2];
            this.belepes = int.Parse(mezok[3]);
            this.dolgozoBer = int.Parse(mezok[4]);
        }

        public Ber(string nev, bool nem, string reszleg, int belepes, int dolgozoBer
            )
        {
            this.nev = nev;
            this.nem = nem;
            this.reszleg = reszleg;
            this.belepes = belepes;
            this.dolgozoBer = dolgozoBer;
        }

        public string Nev { get => nev; set => nev = value; }
        public bool Nem { get => nem; set => nem = value; }
        public string Reszleg { get => reszleg; set => reszleg = value; }
        public int Belepes { get => belepes; set => belepes = value; }
        public int DolgozoBer { get => dolgozoBer; set => dolgozoBer = value; }
    }
}
