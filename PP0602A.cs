using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba_prob;
            string linia;
            liczba_prob = int.Parse(Console.ReadLine());
            for (int i = 0; i < liczba_prob; i++)
            {
                linia = Console.ReadLine();
                string[] tab = linia.Split();
                for (int j = 1; j < tab.Length; j++)
                {
                    if (j % 2 == 0 && tab[j] != null)
                        Console.Write("{0} ",tab[j]);
                }
                for (int j = 1; j < tab.Length; j++)
                {
                    if (j % 2 != 0 && tab[j] != null)
                        Console.Write("{0} ", tab[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
