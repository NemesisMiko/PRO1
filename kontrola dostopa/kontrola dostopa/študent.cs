using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrola_dostopa
{
    internal class študent
    {
        private string študentID;
        public string ime;
        public string naslov;
        private int starost;
        public int Starost
        {
            get { return starost}
            set {
                if (value >= 18)
                    starost = value
                  else
                    starost = -1;
            }
        }
        public double povprečnaOcena;
        public študent()
        {
            študentID = "1234";
            ime = "Janez Novak";
            naslov = "Cankarjeva 5, Nova Gorica";
            starost = 19;
            povprečnaOcena = 7.5;
        }
        public void Izpis()
        {
            Console.WriteLine("*****************ŠTUDENT*****************");
            Console.WriteLine("ID        "+ študentID);
            Console.WriteLine("ime           "+ime);
            Console.WriteLine("naslov        " + naslov);
            Console.WriteLine("strost        " +starost);
            Console.WriteLine("Povprečje        " + povprečnaOcena);
            Console.WriteLine("*****************************************");

        }
    }
}
