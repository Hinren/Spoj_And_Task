using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string linia;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                linia = Console.ReadLine();
                for (int j = 0; j < linia.Length / 2; j++)
                {
                    Console.Write(linia[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
