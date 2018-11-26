using System;

namespace ConsoleApp118
{
    class Program
    {
        const int SIZE = 1000001;
        static void Main(string[] args)
        {
            int[] tab = new int[SIZE];
            const int MODULO = 101010101;
            tab[2] = 4;
            tab[3] = 6;
            for (int i = 4; i < SIZE; i++)
                tab[i] = (tab[i - 2] * 2) % MODULO;
            int n, m;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                m = int.Parse(Console.ReadLine());
                Console.WriteLine(tab[m]);
            }
        }
    }
}
