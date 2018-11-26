using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp86
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            string[] licz;
            int suma = 0;
            while (((y = Console.ReadLine())) != null)
            {

                if (y != null && y.Length > 1)
                {
                    licz = y.Split('\n');
                    for (int i = 0; i < licz.Length; i++)
                    {
                        suma = suma + int.Parse(licz[i]);
                    }

                }
            }
            Console.WriteLine(suma);
        }
    }
}