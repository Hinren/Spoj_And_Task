using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia;
            string[] tab;
            string[] tab2;
            int m = 0;
            while ((linia = Console.ReadLine()) != null)
            {
                tab = linia.Split();
                linia = Console.ReadLine();
                tab2 = linia.Split();
                m += int.Parse(tab[1]);
                for (int i = 0; i < tab2.Length; i++)
                {
                    if (m == tab2.Length)
                    {
                        m = 0;
                        Console.Write("{0} ", tab2[m]);
                    }
                    else
                        Console.Write("{0} ", tab2[m]);

                    m++;
                }
                Console.ReadKey();
            }
        }
    }
}
