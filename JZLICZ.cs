using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp107
{
    class Program
    {
        static void Main(string[] args)
        {
            int zliaczanie = 97;
            int licznik = 0;
            int x = 0, pomoc = 0; ;
            int n = int.Parse(Console.ReadLine());
            string linia = "", linia2 = "";
            string[] tab;
            for (int i = 0; i < n; i++)
            {
                linia2 = Console.ReadLine();
                tab = linia2.Split(' ');
                for (int j = 0; j < tab.Length; j++)
                {
                    linia += tab[j];
                }
            }
            for (int j = 0; j < 52; j++)
            {
                licznik = 0;
                for (int m = 0; m < linia.Length; m++)
                {
                    x = (int)linia[m];
                    if (zliaczanie == 123)
                    {
                        zliaczanie -= 58;
                    }
                    if (x == zliaczanie)
                    {
                        pomoc = x;
                        licznik++;
                    }
                }
                zliaczanie++;
                if (licznik != 0)
                {
                    char test2 = (char)pomoc;
                    Console.WriteLine("{0} {1}", test2, licznik);
                }
            }

            Console.ReadKey();
        }
    }
}
