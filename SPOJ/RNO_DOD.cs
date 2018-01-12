using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp101
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, suma = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                suma = 0;
                m = int.Parse(Console.ReadLine());
                string[] licz = Console.ReadLine().Split();
                if (licz.Length == m)
                {
                    for (int j = 0; j < m; j++)
                    {
                        suma = suma + int.Parse(licz[j]);
                    }
                    Console.WriteLine(suma);
                }
            }
        }
    }
}
