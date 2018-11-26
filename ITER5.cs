using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia;
            linia = Console.ReadLine();
            string[] tab = linia.Split();
            for (int i = 0; i < int.Parse(tab[0]); i++)
            {
                for (int j = 0; j < int.Parse(tab[1]); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
