using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, k;
            string linia;
            linia = Console.ReadLine();
            string[] tab2 = linia.Split();
            k = int.Parse(tab2[0]);
            w = int.Parse(tab2[1]);
            int[,] tab = new int[k, w];
            for (int i = 0; i < k; i++)
            {
                linia = Console.ReadLine();
                tab2 = linia.Split();
                for (int j = 0; j < w; j++)
                {
                    tab[i, j] = int.Parse(tab2[j]);
                }
            }

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write("{0} ", tab[j, i]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
