using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedovanje_absraktni_razredi_vmesini_vaja1
{
    internal class Tovornjak:Vozilo, IDrivable
    {
        int nosilnost;
        int vlečnoZmogljivost;

        public int Nosilnost { get => nosilnost; set => nosilnost = value; }
        public int VlečnoZmogljivost { get => vlečnoZmogljivost; set => vlečnoZmogljivost = value; }

        public double Drive(int štKilometrov)
        {
            return štKilometrov *15 / 100.0;
        }
    }
}
