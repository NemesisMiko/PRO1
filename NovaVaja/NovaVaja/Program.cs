class naloga
{
    class Krog
    {
        public double polmer;

        public double Premer()
        {
            return polmer * 2;
        }

        public double Obseg()
        {
            return Premer() * Math.PI;
        }

        public double Kvadratura()
        {
            return Math.PI * Math.Pow(polmer,2);
        }
    }

    class Krogla: Krog
    {
        new public double Kvadratura()
        {
            return 4 * Math.PI * Math.Pow(polmer, 2);
        }

        public double Volumen()
        {
            return 4 * Math.PI * Math.Pow(polmer, 2)/3;
        }
    }

    static void Main(string[] args)
    {
        Krog k = new Krog();
        k.polmer = 5.0;
        Console.WriteLine("KROG");
        Console.WriteLine("Premer: " + k.Premer());
        Console.WriteLine("Obseg: " + k.Obseg());
        Console.WriteLine("Kvadratura: " + k.Kvadratura());

        Krogla kr = new Krogla();
        kr.polmer = 5.0;
        Console.WriteLine();
        Console.WriteLine("KROG");
        Console.WriteLine("Premer: " + kr.Premer());
        Console.WriteLine("Obseg: " + kr.Obseg());
        Console.WriteLine("Kvadratura: " + kr.Kvadratura());
        Console.WriteLine("Prostornina: " + kr.Volumen());

    }
}
