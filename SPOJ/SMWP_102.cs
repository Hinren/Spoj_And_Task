using System;
namespace ConsoleApp118
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 1000100;
            bool[] tab = new bool[SIZE];
            tab[0] = true;
            tab[1] = true;
            for (int i = 2; i * i < SIZE; i++)
                if (tab[i] == false)
                    for (int j = 2 * i; j < SIZE; j += i)
                        tab[j] = true;
            int n, liczba;
            bool czyPierwsza;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                liczba = int.Parse(Console.ReadLine());
                czyPierwsza = true;

                while (liczba != 0)
                {
                    if (tab[liczba] != false)
                    {
                        czyPierwsza = false;
                        break;
                    }
                    liczba /= 10;
                }
                if (czyPierwsza == true)
                    Console.WriteLine("TAK");
                else
                    Console.WriteLine("NIE");
            }
        }
    }
}