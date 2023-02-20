using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravokotnik_20._2
{
    internal class Pravokotnik
    {
        double dolžina;
        double širina;

        public double Dolžina { get => dolžina; }
        public double Širina { get => širina; }
        public Pravokotnik(int d, int š)
        {
            dolžina = d; širina = š;
        }
        public double GetArea()
        {
            return dolžina * širina;
        }
        public double GetPerimeter()
        {
            return 2 * dolžina + 2 * širina;

        }
        public bool IsSquare()
        {
            if (dolžina == širina)
                return true;
            else
                return false;
        }

    }
}
