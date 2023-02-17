using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja13
{
    class Palcke
    {
        int stPalck;
        int igralec;

        public Palcke()
        {
            stPalck = 7;
            igralec = 1;
        }
        public bool VzemiPalcke(int n)
        {
            if (n < 1 | n > 3)
                return false;
            stPalck = stPalck - n;
            igralec = 3 - igralec;
            return true;
        }
        public bool KonecIgre()
        {
            return (stPalck <= 0);
        }

        public int DobiZmagovalca()
        {
            return igralec;
        }

        public void Izpis()
        {
            Console.WriteLine();
            Console.WriteLine("Na mizi je " + stPalck + " palck");
            Console.WriteLine("Na vrsti je igralec " + igralec+ ".");
        }

    }
}
