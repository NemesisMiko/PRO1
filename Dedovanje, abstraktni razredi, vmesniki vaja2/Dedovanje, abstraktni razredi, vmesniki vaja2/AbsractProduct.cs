using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje__abstraktni_razredi__vmesniki_vaja2
{
    internal abstract class AbsractProduct:IProduct
    {
        protected int edinstvenID;
        protected string ime;
        protected int cena;

        public int EdinstvenID { get => edinstvenID; set => edinstvenID = value; }
        public string Ime { get => ime; set => ime = value; }
        public int Cena { get => cena; set => cena = value; }

        public int GetID(int x)
        {
            return x;
        }

        public string getNGetName(string y)
        {
            return y;
        }

        public double GetPrice(int z)
        {
            return z;
        }
        public abstract string getDescribtion();
    }
}
