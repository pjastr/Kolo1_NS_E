using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_E
{
    class GraPlanszowa:Gra
    {
        private int liczbaGraczy;

        public GraPlanszowa(string p1, double p2, int p3)
            :base(p1,p2)
        {
            this.liczbaGraczy = p3;
        }

        public double CzasRozgrywki()
        {
            return liczbaGraczy * 45.2;
        }
    }
}
