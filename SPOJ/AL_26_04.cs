using System;

namespace ConsoleApp118
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m, s = 0;
            string linia;
            string[] tab;
            for (int i = 0; i < n; i++)
            {
                s = 0;
                m = int.Parse(Console.ReadLine());
                linia = Console.ReadLine();
                tab = linia.Split();
                for (int j = 0; j < m; j++)
                {
                    s ^= int.Parse(tab[j]);
                }
                Console.WriteLine(s);
            }
        }
    }
}
