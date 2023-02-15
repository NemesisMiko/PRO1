using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrola_dostopa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            študent janez = new študent();
            janez.Starost = 19;
            janez.izpis();
            

            Console.ReadLine();
        }
    }
}
