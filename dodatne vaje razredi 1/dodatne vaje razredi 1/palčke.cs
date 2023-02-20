using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodatne_vaje_razredi_1
{
    internal class palčke
    {
        int štpalčk;
        int igralec;//1 ali 2 - kdo je na vrsti

        public int Štpalčk { get => štpalčk;}
        public int Igralec { get => igralec;}
        public palčke()
        {
            igralec = 1;
            štpalčk = 11;
        }
        
        public palčke(int š, int i)
        {
            štpalčk = š;
            igralec = i;
        }
        public void IzpisStanja()
        {
            Console.WriteLine("Na mizi je " + štpalčk + "palčk.");
            Console.WriteLine("Na vrsti je "+igralec);
        }
        public void IzpisStanja1()
        {
            string r = "";
            r = r + "na mizi je " + štpalčk + "palčk";
            r = r + "\n Na vrsti je " + igralec;
            return r;
        }
        //vzemi n palčk iz mize in zamenjaj igralca
        public void VzemiPalčke(int n)
        {
            if (n <1 || n>3)
            {
                Console.WriteLine("ne slepari");
                return;
            }
            štpalčk = štpalčk - n;
            igralec = 3 - igralec;
        }
        public bool jekonec()
        {
            return štpalčk <= 0;
        }
        public int dobizmagovalca()
        {
            return igralec;
        }
    }
}
