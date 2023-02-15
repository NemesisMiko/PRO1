using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi_predavanja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Napis x = new Napis();
            x.najljubšiProgram = "C#";
            x.Izpiši();
            x.Kolliko();
            Napis y = new Napis();
            y.najljubšiProgram = "Python";
            y.Izpiši();
            y.Kolliko();
            

            Console.WriteLine("Kateri je tvoj najljubši p.j");
            string moj = Console.ReadLine();
            Napis z = new Napis(moj);
            z.Izpiši();
            Console.ReadLine();
        }
    }
}
