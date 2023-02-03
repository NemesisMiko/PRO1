// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

class projekt
{
    static void Main(string[] args)
    {
        int[] temperature = new int[12];

        int povp = 0;
        int vsota = 0;

        for (int i = 0; i < temperature.Length; i++) 
        {
            Console.Write("Vnesi povp temp za " + (i + 1) + " mesec ");
            temperature[i] = int.Parse(Console.ReadLine());

            vsota = vsota + temperature[i];
            

            
        }
        povp = vsota / 12;
        Console.WriteLine("Mrzli meseci: ");
        for(int i = 0; i < temperature.Length; i++)
        {
            if (temperature[i] < povp)
            {
                Console.WriteLine((i + 1) + ". mesec ");
            }
        }




    }
}
