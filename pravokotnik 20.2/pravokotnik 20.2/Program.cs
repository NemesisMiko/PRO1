using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravokotnik_20._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pravokotnik a = new Pravokotnik(3, 3);
            Pravokotnik b = new Pravokotnik(8,4);
            Console.WriteLine("Površina pravokotnika a je "+ a.GetArea() + " Površina pravokotnika b je " + b.GetArea());
            Console.WriteLine("Obseg pravokotnika a je "+ a.GetPerimeter() + " Obseg pravokotnika b je " + b.GetPerimeter());
            Console.WriteLine("Ali je pravokotnik a kvadrat? "+a.IsSquare() + " Ali je pravokotnik b kvadrat? " + b.IsSquare());
            Console.ReadLine();

        }
    }
}
