using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razredi_20._2
{
    internal class oseba1
    {
        string ime;
        int starost;

        public string Ime { get => ime; }
        public int Starost { get => starost;}
        public oseba1(string i, int s)
        {
            ime = i; starost = s;
        }
        public int GetAgeInMonths()
        {
            return 12*starost;
        }
        public bool IsAdult()
        {
            if (starost < 18)
                return false;
            else
                return true;
        }
        public bool IsEqual(oseba1 x)
        {
            if (this.ime == x.ime && this.starost == x.starost)
                return true;
            return false;
        }
    }
}
