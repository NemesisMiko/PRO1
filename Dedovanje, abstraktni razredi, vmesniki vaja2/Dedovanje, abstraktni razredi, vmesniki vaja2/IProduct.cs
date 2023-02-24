using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje__abstraktni_razredi__vmesniki_vaja2
{
    internal interface IProduct
    {
        int GetID(int x);
        string getNGetName(string y);
        double GetPrice(int z);
    }
}
