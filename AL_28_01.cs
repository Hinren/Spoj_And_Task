using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp117
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int lenght, a, b;
            lenght = int.Parse(Console.ReadLine());
            word = Console.ReadLine();
            a = b = lenght / 2;
            while (a >= 0)
            {
                for (int i = 0; i < lenght; i++)
                {
                    if (i >= a && i <= b)
                        Console.Write(word[i]);
                    else
                        Console.Write(".");
                }
                a--; b++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

