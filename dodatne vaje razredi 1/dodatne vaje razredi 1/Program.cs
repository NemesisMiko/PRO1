using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodatne_vaje_razredi_1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            palčke p = new palčke(15,2);
            while (!p.jekonec())
            {
                p.IzpisStanja();
                Console.WriteLine("Koliko palčk vzameš?");
                int x = int.Parse(Console.ReadLine());
                p.VzemiPalčke(x);
            }
            Console.WriteLine("Zmagal je igralec "+ p.dobizmagovalca());
            Console.ReadLine();
        }
    }
}
