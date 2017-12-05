using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_E
{
    class Gra
    {
        protected string nazwa;
        protected double cena;

        public Gra(string p1, double p2)
        {
            this.nazwa = p1;
            this.cena = p2;
        }

        public string Opis()
        {
            return nazwa + " " + cena;
        }
    }
}
