using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedovanje_absraktni_razredi_vmesini_vaja1
{
    internal class Avto:Vozilo, IDrivable
    {
        int štVrat;
        int velikostPrtljažnika;

        public int ŠtVrat { get => štVrat; set => štVrat = value; }
        public int VelikostPrtljažnika { get => velikostPrtljažnika; set => velikostPrtljažnika = value; }

        public double Drive(int štKilometrov)
        {
            return štKilometrov * 6 / 100.0;
        }
    }
}
