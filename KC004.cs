using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia;
            string[] tab;
            int sprawdz, licznik = 0;
            while ((linia = Console.ReadLine()) != null)
            {
                tab = linia.Split(' ');
                licznik = 0;
                sprawdz = int.Parse(tab[0]);
                for (int i = 2; i < tab.Length; i++)
                {
                    if (sprawdz == int.Parse(tab[i]))
                        licznik++;
                }
                Console.WriteLine(licznik);
                Console.ReadKey();
            }
        }
    }
}
