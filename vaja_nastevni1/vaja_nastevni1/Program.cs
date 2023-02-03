using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_nastevni1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Vnesite tip klica");
            //string tip = Console.ReadLine();
            //Console.WriteLine("Koliko munut?");
            //string minute = Console.ReadLine();
            //double znesek = 0;

            //if (tip == "KlicvMobilno")
            //{
            //    znesek = double.Parse(minute) * 0.03;
            //    Console.WriteLine("plačati morate" + znesek + "€");
            //}
            //else
            //{
            //    znesek = double.Parse(minute) * 0.2;
            //    Console.WriteLine("plačati morate" + znesek + "€");
            //}
            //Console.ReadLine();

            Random r = new Random();
            int barva = r.Next(4);
            int vrednost = r.Next(13);
            Console.WriteLine((barva)barva + "," + (vrednost)vrednost);
            Console.ReadLine();
            
            


        }
    }
}
