using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc_lini;
            int zacznij = 2;
            string linia;
            ilosc_lini = int.Parse(Console.ReadLine());
            for (int i = 0; i < ilosc_lini; i++)
            {
                linia = Console.ReadLine();
                string[] tab = linia.Split();

                for (int j = 0; j < tab.Length - 1; j++)
                {
                    if (zacznij >= tab.Length)
                        zacznij = 1;
                    Console.Write(tab[zacznij] + " ");
                    zacznij++;
                }
                Console.WriteLine();
            }
        }
    }
}
