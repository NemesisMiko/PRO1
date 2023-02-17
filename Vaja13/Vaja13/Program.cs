using Vaja13;

using Microsoft.VisualBasic;

class program
{
    static void main(String[] args)
    {
        Palcke p = new Palcke();
        while (!p.KonecIgre())
        {
            p.Izpis();
            Console.Write("Koliko palck vzames? ");
            int n = int.Parse(Console.ReadLine());
            if (p.VzemiPalcke(n))
            {
                Console.WriteLine("Stevilo palck je napacno.");
            }
           
        }
        Console.WriteLine("Zmagal je igralec: " + p.DobiZmagovalca());
    }
}