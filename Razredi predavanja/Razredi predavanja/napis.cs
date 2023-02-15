using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi_predavanja
{
    internal class Napis
    {
        public string najljubšiProgram;
        public static int štIzvodov;
        public void Izpiši()
        {
            Console.WriteLine("Rad imam "+ najljubšiProgram );
        }
        public Napis()
        {
            najljubšiProgram = "?????????????????";
            Console.WriteLine("konstruktor brez parametrov");
            štIzvodov++;
        }
        public Napis(string n)
        {
            najljubšiProgram = n;
            Console.WriteLine("Konstruktor s parametri");
            štIzvodov++;
        }
        public void Kolliko()
        {
            Console.WriteLine("Število objektov tipa Napis je "+ štIzvodov);
        }
    }
}
