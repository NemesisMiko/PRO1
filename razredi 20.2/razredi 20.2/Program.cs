using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razredi_20._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            oseba1 a = new oseba1("Miha", 19);
            oseba1 b = new oseba1("Marija", 16);
            Console.WriteLine(a.Ime +" Je polnoleten? " +a.IsAdult());
            Console.WriteLine(a.Ime + " je ista oseba kot "+b.Ime +" ? "+a.IsEqual(b));
            Console.ReadLine();

        }
    }
}
