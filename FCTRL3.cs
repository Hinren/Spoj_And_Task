using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silnia3
{
    class Program
    {
        static void Main(string[] args)
        {

            int liczba = int.Parse(Console.ReadLine());
            if (liczba > 0 && liczba <= 30)
            {

                for (int i = 0; i < liczba; i++)
                {
                    int l = int.Parse(Console.ReadLine());
                    if (l > 9)
                        Console.WriteLine(0 + " " + 0);
                    else if (l > 1 && 10 > l)
                    {
                        int wynik = 1;
                        for (int z = l; z > 0; z--)
                        {
                            wynik *= z;
                        }
                        string wynik2 = Convert.ToString(wynik);
                        if (wynik2.Length > 1)
                        {
                            Console.WriteLine(wynik2[wynik2.Length - 2] + " " + wynik2[wynik2.Length - 1]);
                        }
                        else Console.WriteLine(0 + " " + wynik2);

                    }
                    else if (l == 0 || l == 1)
                    {
                        Console.WriteLine(0 + " " + 1);
                    }

                }
            }
            Console.ReadKey();

        }
    }
}
