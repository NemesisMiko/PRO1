using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razredi_vaja1_krog
{
    internal class Valj:krog
    {
        int višina;
        public Valj(int xK, int yK, double rK, int vK) :base( xK,  yK,  rK)
        {
            višina = vK;
        }

        public int Višina { get => višina; set => višina = value; }
        public double Površina()
        {
            return 2 * Math.PI * radij;
        }
        public double Volumen()
        {
            return Površina() * višina;
        }
    }
}
