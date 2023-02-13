using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_Pi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double člen= 1;
            double vsota = 1;
            Console.WriteLine( "vnesi vrednost x");
            double x = double.Parse(Console.ReadLine());
            //for (int i =1; i <= 100; i++)
            int k = 1; 
            while (Math.Abs(vsota -Math.Exp(x))>0.000001)
            {
                člen = člen * x /k ;
                vsota = vsota + člen;
                k++;
            }
            Console.WriteLine("vsota je "+vsota);
            Console.WriteLine("e na x je " + Math.Exp(x));
            Console.ReadLine();

        }
    }
}
