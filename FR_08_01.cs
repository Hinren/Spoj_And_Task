using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp93
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            int a = 0;
            string wypisz = null;
            while (((y = Console.ReadLine())) != null)
            {


                for (int i = 0; i < y.Length; i++)
                {
                    a = y[i] - 48;
                    if (a % 2 == 0)
                    {
                        wypisz = "Tak";
                        break;
                    }
                    else
                    {
                        wypisz = "Nie";
                    }
                }

                Console.WriteLine(wypisz);
            }
        }
    }
}
