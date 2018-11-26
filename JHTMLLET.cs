using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            Char x;
            while (((y = Console.ReadLine())) != null)
            {
                for (int i = 0; i < y.Length; i++)
                {
                    x = y[i];
                    if (x == '<')
                    {
                        for (int j = i; j < y.Length; j++)
                        {
                            x = y[j];
                            Console.Write(char.ToUpper(x));
                            if (x == '>')
                            {
                                break;
                            }
                            i++;
                        }
                    }
                    else
                    {
                        Console.Write(x);
                    }

                }
                Console.WriteLine();

            }
        }
    }
}