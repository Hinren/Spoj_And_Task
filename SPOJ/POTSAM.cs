using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            string[] licz;
            int wynik = 0, wynik2 = 0;
            while (((y = Console.ReadLine())) != null)
            {
                if (y != null)
                {
                    licz = y.Split(' ');
                    for (int i = 0; i < licz.Length; i++)
                    {
                        if (i == 0)
                        {
                            wynik = int.Parse(licz[i]) * int.Parse(licz[i + 1]);
                        }
                        if (i == 2)
                        {
                            wynik2 = wynik + (int.Parse(licz[i]) * int.Parse(licz[i + 1]));
                        }
                    }
                }
                Console.WriteLine(wynik2);
            }
        }
    }
}
