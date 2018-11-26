using System;
namespace ConsoleApp118
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia = Console.ReadLine();
            string[] tab;
            float r, d, r_2;
            tab = linia.Split();
            r = float.Parse(tab[0]);
            d = float.Parse(tab[1]);
            r_2 = r * r - d * d / 4;
            double pole = 3.141592654 * r_2;
            Console.WriteLine(Math.Round(pole, 2, MidpointRounding.AwayFromZero));
            Console.ReadKey();
        }
    }
}