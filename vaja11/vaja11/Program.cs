using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi poljubno celo tri mestno število");
            int x = int.Parse(Console.ReadLine());
            int a = x % 10;
            int f = x / 10;
            int b = f % 10;
            int c = f / 10;

            if (a % 2 == 0 & b% 2 == 0 & c % 2 ==0)
                Console.WriteLine("Številke so sode ");
            else if (a % 2 == 1 & b % 2 == 1 & c % 2 == 1)
                Console.WriteLine("številke so lihe");
            else  
                Console.WriteLine("številke so lihe in sode");


            Console.WriteLine("Vnesite temperaturo vode med 5 in 100");
            int t = int.Parse(Console.ReadLine());
            if (t <= 10)
                Console.WriteLine("voda je zelo mrzla");
            else if (t <= 20 & 10 < t)
                Console.WriteLine("voda je hladna");
            else if (t <= 30 & 20 < t)
                Console.WriteLine("voda je topla");
            else if (t <= 50 & 30 < t)
                Console.WriteLine("voda je vroča");
            else if (50 < t)
                Console.WriteLine("voda je zelo vroča");


            Console.WriteLine("vnesi oddelek študenta 1-ang, 2-mat, 3-nar");
            int odd = int.Parse(Console.ReadLine());
            int delni1 = 0;
            int delni2 = 0;
            int delni3 = 0;
            int delni4 = 0;
            double KončnaOcena = 0;
            string črka;
            switch(odd)
            {
                case 1: //ang
                    Console.WriteLine("Vnesi oceno delni1");
                    delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno delni2");
                    delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno delni3");
                    delni4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno delni4");
                    delni3 = int.Parse(Console.ReadLine());
                    KončnaOcena = 0.25 * delni1 + 0.25 * delni2 + 0.3 * delni3 +  0.2 * delni4;
                    if (KončnaOcena >= 93)
                        črka = "A";
                    else if (KončnaOcena >= 85)
                        črka = "B";
                    else if (KončnaOcena >= 78)
                        črka = "C";
                    else if (KončnaOcena >= 70)
                        črka = "D";
                    else črka = "F";
                    Console.WriteLine("Končna črka je " + črka);
                    break;
                case 2: //mat
                    Console.WriteLine("Vnesi oceno delni1");
                    delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno delni2");
                    delni2 = int.Parse(Console.ReadLine());
                    KončnaOcena = 0.5 + delni1 + 0.5 * delni2;
                    if (KončnaOcena >= 90)
                        črka = "A";
                    else if(KončnaOcena >= 83)
                        črka = "B";
                    else if(KončnaOcena >= 76)
                        črka = "C";
                    else if (KončnaOcena >= 65)
                        črka = "D";
                    else črka = "F";
                    Console.WriteLine("Končna črka je " + črka);
                    break;

                case 3: //nar
                    Console.WriteLine("Vnesi oceno delni1");
                    delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno delni2");
                    delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno delni3");
                    delni3 = int.Parse(Console.ReadLine());
                    KončnaOcena = 0.4 + delni1 + 0.4 * delni2 + 0.2 * delni3;
                    if (KončnaOcena >= 90)
                        črka = "A";
                    else if (KončnaOcena >= 80)
                        črka = "B";
                    else if (KončnaOcena >= 70)
                        črka = "C";
                    else if (KončnaOcena >= 60)
                        črka = "D";
                    else črka = "F";
                    Console.WriteLine("Končna črka je " + črka);
                    break;


            }




        }
    }
}
