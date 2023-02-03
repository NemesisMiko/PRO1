using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Vnesi eno celo število");
            int a = int.Parse (Console.ReadLine());
            Console.WriteLine("Vnesi še eno celo število");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("vnesi še eno celo število");
            int c = int.Parse(Console.ReadLine());
            if (a + b > c & a + c > b & b + c > a)
                Console.WriteLine("So stranice trikotnika");
            else Console.WriteLine("Niso stranice trikotnika");
            

            

        }
    }
}
