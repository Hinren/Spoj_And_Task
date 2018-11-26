using System;

namespace ConsoleApp118
{
    class Program
    {
        const int doba = 86400;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m, y, czas, czas_pudelko = 0, pudelka = 0;
            string linia;
            string[] tab;
            for (int i = 0; i < n; i++)
            {
                czas_pudelko = 0;
                linia = Console.ReadLine();
                tab = linia.Split();
                m = int.Parse(tab[0]);
                y = int.Parse(tab[1]);
                for (int j = 0; j < m; j++)
                {
                    czas = int.Parse(Console.ReadLine());
                    czas_pudelko += doba / czas;
                }
                if (czas_pudelko % y == 0) pudelka = czas_pudelko / y;
                else pudelka = (czas_pudelko / y) + 1;
                Console.WriteLine(pudelka);
            }
        }
    }
}