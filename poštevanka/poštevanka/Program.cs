using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poštevanka
{
    internal class Program
    {
        static void Main(string[] args)


        {

            int x = 0;
            int vsota = 0;
            Random y = new Random();

            Console.WriteLine("Vnesi poljuben število");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                int z = y.Next(1, 10);
                Console.WriteLine("Koliko je "+ x + " x " + z);
                int a = int.Parse(Console.ReadLine());
                if (a == x * z)
                    vsota++;
            
                
            }
            Console.WriteLine("Pravilni odgovori so" + vsota);
          

            Console.WriteLine("Ali bi želel ponoviti program? (da / ne)");
            string odgovorUporabnika = Console.ReadLine();

            if (odgovorUporabnika == "da")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Končal si program!");
            }
        }
    }
}
