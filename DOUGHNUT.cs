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
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tab = Console.ReadLine().Split();
                int x = int.Parse(tab[0]);
                int y = int.Parse(tab[1]);
                int z = int.Parse(tab[2]);
                if (x * z <= y)
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
            }
        }
    }
}
