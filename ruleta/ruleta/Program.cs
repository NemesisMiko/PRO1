using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ruleta
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Koliko denarja želite vložiti?");
            int stanje = int.Parse(Console.ReadLine());
            Console.WriteLine("koliko želite staviti?");
            int stava = int.Parse(Console.ReadLine());
            int začStanje = stanje;
            int začStava = stava;
            int minStanje =stanje;
            int MaxStanje =stanje;
            Random r = new Random();

            for (int i = 0; i < 11; i++)
            {
                
                int z = r.Next(0, 36);
                if (z % 2 == 0 & z != 0 )
                {
                    stanje = stanje + stava;
                    stava = začStava;
                   
                   
                    Console.WriteLine("barva je rdeča stanje:" + stanje);
                    ;
                }
                else
                {
                    stanje = stanje - stava;
                    stava = stava * 2;
                   
                   
                    Console.WriteLine("barva je črna stanje:" + stanje);
                }

                if (stanje < minStanje)
                    minStanje = stanje;
                if (stanje > MaxStanje)
                    MaxStanje = stanje;
            }
            Console.WriteLine("število metov 10");
            Console.WriteLine("Začetno stanje "+ začStanje);
            Console.WriteLine("Končno stanje "+ stanje);
            Console.WriteLine("Najvišje stanje " + MaxStanje);
            Console.WriteLine("Najnižje stanje "+minStanje);
            Console.WriteLine("dobiček ali izguba"+(stanje - začStanje));
        }
        
    }
}
