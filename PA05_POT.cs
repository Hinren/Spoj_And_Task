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
                int x = int.Parse(licz[0]) % 10;
                int y = int.Parse(licz[1]) - 1;
                if (x == 0)
                {
                    Console.WriteLine(0);
                }
                else if (x == 1)
                {
                    Console.WriteLine(1);
                }
                else if (x == 2)
                {
                    if (y % 4 == 0)
                        Console.WriteLine(2);
                    else if (y % 4 == 1)
                        Console.WriteLine(4);
                    else if (y % 4 == 2)
                        Console.WriteLine(8);
                    else if (y % 4 == 3)
                        Console.WriteLine(6);
                }
                else if (x == 3)
                {
                    if (y % 4 == 0)
                        Console.WriteLine(3);
                    else if (y % 4 == 1)
                        Console.WriteLine(9);
                    else if (y % 4 == 2)
                        Console.WriteLine(7);
                    else if (y % 4 == 3)
                        Console.WriteLine(1);
                }
                else if (x == 4)
                {
                    if (y % 2 == 0)
                        Console.WriteLine(4);
                    else if (y % 2 == 1)
                        Console.WriteLine(6);

                }
                else if (x == 5)
                {
                    Console.WriteLine(5);
                }
                else if (x == 6)
                {
                    Console.WriteLine(6);
                }
                else if (x == 7)
                {
                    if (y % 4 == 0)
                        Console.WriteLine(7);
                    else if (y % 4 == 1)
                        Console.WriteLine(9);
                    else if (y % 4 == 2)
                        Console.WriteLine(3);
                    else if (y % 4 == 3)
                        Console.WriteLine(1);
                }
                else if (x == 8)
                {
                    if (y % 4 == 0)
                        Console.WriteLine(6);
                    else if (y % 4 == 1)
                        Console.WriteLine(4);
                    else if (y % 4 == 2)
                        Console.WriteLine(2);
                    else if (y % 4 == 3)
                        Console.WriteLine(6);
                }
                else if (x == 9)
                {
                    if (y % 2 == 0)
                        Console.WriteLine(9);
                    else if (y % 2 == 1)
                        Console.WriteLine(1);
                }
            }
        }
    }
}
