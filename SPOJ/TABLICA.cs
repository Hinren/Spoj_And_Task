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
            while (((y = Console.ReadLine())) != null)
            {
                if (y != null)
                {
                    licz = y.Split(' ');
                    for (int i = licz.Length; i > 0; i--)
                    {
                        Console.Write("{0} ", licz[i - 1]);
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
