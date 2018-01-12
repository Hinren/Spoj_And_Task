using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int nwd(int a, int b)
        {
            int a_ = a;
            int b_ = b;
            int wynik = 0;
            int test;
            if ((a >= 0 && b >= 0) && (a <= 1000000 && b <= 1000000))
            {
                if (b < a)
                {
                    test = b;
                }
                else test = a;

                for (int i = test; i > 0; i--)
                {
                    if (b % i == 0 && a % i == 0)
                    {
                        wynik = i;
                        break;
                    }
                }
            }
            return wynik;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a, b;
            for (int i = 0; i < n; i++)
            {
                string linia = Console.ReadLine();
                string[] tab = linia.Split(' ');
                a = int.Parse(tab[0]);
                b = int.Parse(tab[1]);
                Console.WriteLine(nwd(a, b));
            }
        }
    }
}
