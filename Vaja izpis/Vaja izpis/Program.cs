using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_izpis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1234;
            //int b = 5678;
            //onsole.WriteLine("a=" + a + " b=" + b);
            //formatiranje izpisa
            //Console.WriteLine("a={0} b={1}",a,b);
            //Console.WriteLine("a={0,6} b={1,6}", a, b);
            //Console.WriteLine("a={0,6:d} b={1,6:x}", a, b);
            //double r = 12345.6789;
            //Console.WriteLine("r={0,10:f2}",r);
            //Console.WriteLine("r={0,10:e2}", r);
            //Console.WriteLine("r={0,10:g2}", r);
            //Console.WriteLine("r={0,10:n2}", r);
            // double p = 0.25
            //Console.WriteLine("p={0,10:p2}", p);
            //double a = 20;
            //double b = -13.6667;
            //double c = 17;
            //double d = 12.88;
            //double e = 2222.879;
            //Console.WriteLine("{0,20:f2}", a);
            //Console.WriteLine("{0,20:f2}", b);
            //Console.WriteLine("{0,20:f2}", c);
            //Console.WriteLine("{0,20:f2}", d);
            //Console.WriteLine("{0,20:f2}", e);
            char znak ='?';
            int ascii = znak;
            Console.WriteLine(znak +" Ima kodo "+ ascii);
            ascii = 69;
            znak = (char)ascii;
            Console.WriteLine(ascii + " ascii kodo ima znak "+ znak );
            Console.ReadLine();
            ////? ima ascii kodo 
            ////ascii 69
            //   // asci kodo 69 ima znak
            //Console.ReadLine();
        }
    }
}
