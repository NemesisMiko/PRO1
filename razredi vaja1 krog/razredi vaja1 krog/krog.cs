using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razredi_vaja1_krog
{
    internal class krog
    {
        protected int x;
        protected int y;
        protected double radij;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public double Radij { get => radij; set => radij = value; }

        public krog(int xK,int  yK,double rK)
        {
            x = xK;
            y = yK;
            radij = rK;
        }
        public double Premer()
        {
            return radij * 2;
        }
        public double Ploščina()
        {
            return Math.PI * (radij * radij);
        }
    }
}
