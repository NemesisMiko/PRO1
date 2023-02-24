using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje__abstraktni_razredi__vmesniki_vaja2
{
    internal class Book:AbsractProduct
    {
        string Description;
        double DiscountedPrice;

        public string GetDescribtion()
        {
            return Description;
        }
        public double GetDiscountedPrice()
        {
            return DiscountedPrice;
        }
    }
}
