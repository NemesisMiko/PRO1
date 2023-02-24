using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedovanje_absraktni_razredi_vmesini_vaja1
{
    internal abstract class Vozilo
    {
        protected string proizvajalec;
        protected string model;
        protected int leto;
        protected string barva;

        public string Proizvajalec { get => proizvajalec; set => proizvajalec = value; }
        public string Model { get => model; set => model = value; }
        public int Leto { get => leto; set => leto = value; }
        public string Barva { get => barva; set => barva = value; }
    }
}
