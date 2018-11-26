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
            int n = int.Parse(Console.ReadLine());
            int a, b;
            string[] tab;
            for (int i = 0; i < n; i++)
            {
                string linia = Console.ReadLine();
                tab = linia.Split();
                a = int.Parse(tab[0]);
                b = int.Parse(tab[1]);
                if (a % 2 != 0)
                    Console.WriteLine("BRAK");
                else
                {
                    if (b > a / 2)
                        Console.WriteLine(b - a / 2);
                    else
                        Console.WriteLine(b + a / 2);
                }
            }
        }
    }
}
