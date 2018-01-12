using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp103
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia;
            int wynik;
            while ((linia = Console.ReadLine()) != null)
            {
                wynik = 0;
                string[] tab = linia.Split(' ');
                if (tab[0] == "+")
                {
                    wynik = int.Parse(tab[1]) + int.Parse(tab[2]);
                }
                else if (tab[0] == "-")
                {
                    wynik = int.Parse(tab[1]) - int.Parse(tab[2]);
                }
                else if (tab[0] == "*")
                {
                    wynik = int.Parse(tab[1]) * int.Parse(tab[2]);
                }
                else if (tab[0] == "/")
                {
                    wynik = int.Parse(tab[1]) / int.Parse(tab[2]);
                }
                else if (tab[0] == "%")
                {
                    wynik = int.Parse(tab[1]) % int.Parse(tab[2]);
                }
                Console.WriteLine(wynik);
            }
        }
    }
}
