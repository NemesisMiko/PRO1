class program
{
    class demo
    {
        int polje;
        public demo()
        {
            polje = 0;
        }

        public int MojaLastnost
        {
            get //metoda za pridobivanje lastnosti polja
            {
                return polje;
            }
            set // metoda za nastavljanje vrednost lastnosti polja
            {
                polje = value;
            }
        }
    }

    static void Main(string[] args)
    {
        demo objekt = new demo();
        Console.WriteLine("Vrednost: " + objekt.MojaLastnost);
        objekt.MojaLastnost = 10;
        Console.WriteLine("Vrednost: " + objekt.MojaLastnost);
        objekt.MojaLastnost = -10;
        Console.WriteLine("Vrednost: " + objekt.MojaLastnost);
    }
}