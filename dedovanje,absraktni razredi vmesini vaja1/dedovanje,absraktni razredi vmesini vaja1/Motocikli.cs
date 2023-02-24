using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedovanje_absraktni_razredi_vmesini_vaja1
{
    internal class Motocikli:Vozilo, IDrivable
    {
        int štKoles;
        int maxHitrost;

        public int ŠtKoles { get => štKoles; set => štKoles = value; }
        public int MaxHitrost { get => maxHitrost; set => maxHitrost = value; }

        public double Drive(int štKilometrov)
        {
            return štKilometrov *8 / 100.0;
        }
    }
}
