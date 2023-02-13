using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_PROI
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int count = 0;

            for (int k = 97; k<=122; k++) //10x ponovi
            {
                
                Console.WriteLine("{0}:{1} ", (char)k,k);
                count++;
                
                    if (count %10 == 0)
                

            }//konec for 

            Console.WriteLine();
            Console.ReadLine();

        }

    }
}
