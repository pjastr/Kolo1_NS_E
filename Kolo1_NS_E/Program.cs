using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_E
{
    class Program
    {
        static void Main(string[] args)
        {
            Gra g1 = new Gra("sddds", 34);
            Gra g2 = new Gra("mhgf", 256);
            GraPlanszowa g3 = new GraPlanszowa("dd", 34, 3);
            GraPlanszowa g4 = new GraPlanszowa("dtd", 78, 2);
            GraPC g5 = new GraPC("dsddf", 55, 6);
            GraPC g6 = new GraPC("poiu", 22, 7);
            g3.CzasRozgrywki();
            g4.CzasRozgrywki();
            g5.Multiplayer();
            g6.Multiplayer();
            Console.WriteLine(g1.Opis());
            Console.WriteLine(g2.Opis());
            Console.WriteLine(g3.Opis());
            Console.WriteLine(g4.Opis());
            Console.WriteLine(g5.Opis());
            Console.WriteLine(g6.Opis());

            Console.ReadKey();
        }
    }
}
