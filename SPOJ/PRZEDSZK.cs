using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp106
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] tab;
            int liczba_1, liczba_2, max, pomoc, min;
            for (int i = 0; i < n; i++)
            {
                string linia = Console.ReadLine();
                tab = linia.Split(' ');
                liczba_1 = int.Parse(tab[0]);
                liczba_2 = int.Parse(tab[1]);
                if (liczba_1 > liczba_2)
                {
                    max = liczba_1;
                    pomoc = liczba_1;
                    min = liczba_2;
                }
                else
                {
                    max = liczba_2;
                    pomoc = liczba_2;
                    min = liczba_1;
                }
                for (int m = 0; m < 999; m++)
                {
                    if (max % min == 0)
                    {
                        break;
                    }
                    else
                    {
                        max = max + pomoc;
                    }
                }

                Console.WriteLine(max);
                Console.ReadKey();
            }
        }
    }
}
