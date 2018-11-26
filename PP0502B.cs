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
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] licz = Console.ReadLine().Split();
                for (int j = licz.Length - 1; j >= 1; j--)
                {
                    Console.Write(licz[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
