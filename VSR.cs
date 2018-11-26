using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp93
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int wynik;
            string[] tab;
            for (int i = 0; i < n; i++)
            {
                string linia = Console.ReadLine();
                tab = linia.Split(' ');
                int a = int.Parse(tab[0]);
                int b = int.Parse(tab[1]);
                wynik = (2 * a * b) / (a + b);
                Console.WriteLine(wynik);
            }
            Console.ReadKey();
        }
    }
}
