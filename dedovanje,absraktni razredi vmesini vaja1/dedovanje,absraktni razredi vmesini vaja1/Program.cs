using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedovanje_absraktni_razredi_vmesini_vaja1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avto a = new Avto();
            a.ŠtVrat = 5;
            a.Barva = "rdeča";
            a.Proizvajalec = "Alfa romeo";
            a.Model = "Julieta";
            a.Leto = 2023;
            Console.WriteLine("Avto******");
            Console.WriteLine("Proizvajalec "+ a.Proizvajalec);
            Console.WriteLine("Model "+ a.Model);
            Console.WriteLine("Barva "+ a.Barva);
            Console.WriteLine("Leto "+ a.Leto);
            Console.WriteLine("Število vrat "+ a.ŠtVrat);
            Console.WriteLine("Za 30km porabiš "+a.Drive(30)+" litrov.");
            

            Tovornjak b = new Tovornjak();
            Console.WriteLine("Za 30km porabiš " + b.Drive(30) + " litrov.");
            Console.WriteLine("tovornjak");

            Motocikli c = new Motocikli();
            Console.WriteLine("Za 30km porabiš " + c.Drive(30) + " litrov.");
            Console.WriteLine("motocikli");
            Console.ReadLine();
        }
    }
}
