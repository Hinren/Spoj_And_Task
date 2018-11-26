using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp117
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int n = int.Parse(Console.ReadLine());
            string[] tab;
            for (int i = 0; i < n; i++)
            {
                string linia = Console.ReadLine();
                tab = linia.Split();
                a = int.Parse(tab[0]);
                b = int.Parse(tab[1]);
                Console.WriteLine(wynik(a, b));
            }
        }
        static int wynik(int a, int b)
        {
            int tmp;
            while (b > 0)
            {
                tmp = a % b;
                a = b;
                b = tmp;
            }
            return a * 2;
        }
    }
}
