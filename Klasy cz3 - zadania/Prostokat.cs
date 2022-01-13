using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_cz3_zadania
{
    internal class Prostokat
    {
        int dlugosc;
        int szerokosc;
        private int p;
        private int o;

        public Prostokat(int d, int s)
        {
            dlugosc = d;
            szerokosc = s;
        }

        private double Powierzchnia()
        {
            p = dlugosc * szerokosc;
            return p;
        }
        private double Obwod()
        {
            o = 2 * (dlugosc + szerokosc);
            return o;
        }

        public void Prezentuj()
        {
            Powierzchnia();
            Obwod();
            Console.WriteLine("Powierzchnia: {0}", p);
            Console.WriteLine("Obwód: {0}", o);
        }

        public static double Najwieksze(Prostokat[] tab)
        { 
            double najwieksze = 0;
            for (int i = 0; i < tab.Length; i++)
            {                
                najwieksze = Math.Max(najwieksze, tab[i].Powierzchnia());                
            }
            return najwieksze;
        }
    }
    // 2. Uzupełnij program z poprzedniego zadania o definicję metody statycznej,
    // która podaje powierzchnię największego prostokąta.
}
