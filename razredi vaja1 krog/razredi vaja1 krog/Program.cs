using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razredi_vaja1_krog
{
    internal class Program
    {
        static void Main(string[] args)
        {

            krog k = new krog(37, 45, 2.5);
            Console.WriteLine("X koordinata = " + k.X +
            "\nY koordinata = " + k.Y +
            "\nRadij =" + k.Radij);
            Console.WriteLine("Premer = " + k.Premer());
            Console.WriteLine("Plošcina =" + k.Ploščina());
            k.X = 2;
            k.Y = 2;
            k.Radij = 4.25f;
            Console.WriteLine("Nova pozicija :");
            Console.WriteLine("X koordinata = " + k.X +
            "\nY koordinata = " + k.Y +
            "\nRadij =" + k.Radij);
            Console.WriteLine("Premer = " + k.Premer());
            Console.WriteLine("Plošcina =" + k.Ploščina());

            Console.WriteLine("_________________");

            Valj v = new Valj(37, 45, 2.5f, 1);
            Console.WriteLine("X koordinata = " + v.X +
            "\nY koordinata = " + v.Y +
            "\nRadij =" + v.Radij +
            "\nVišina =" + v.Višina);
            Console.WriteLine("Površina = " + v.Površina());
            Console.WriteLine("Volumen =" + v.Volumen());

            Console.ReadLine();
        }   
    }
}
