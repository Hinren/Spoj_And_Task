using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp118
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string linia;
            int licznik = 0, j = 0;
            for (int i = 0; i < n; i++)
            {
                j = 0;
                licznik = 0;
                linia = Console.ReadLine();
                for (int m = 0; m < linia.Length; m++)
                {
                    if (linia[j] != linia[m])
                    {
                        if (licznik > 2)
                            Console.Write(linia[m - 1].ToString() + licznik);
                        else if (licznik == 1)
                            Console.Write(linia[m - 1].ToString());
                        else
                            Console.Write(linia[m - 1].ToString() + linia[m - 1].ToString());
                        licznik = 0;
                        j = m;
                        m--;
                    }
                    if (linia[j] == linia[m])
                        licznik++;
                }
                if (licznik > 2)
                    Console.Write(linia[j].ToString() + licznik);
                else if (licznik == 1)
                    Console.Write(linia[j].ToString());
                else
                    Console.Write(linia[j].ToString() + linia[j].ToString());
                Console.WriteLine("");
                Console.ReadKey();
            }
        }
    }
}
