using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int how = 0;
                string text = Console.ReadLine();
                int number = int.Parse(text);
                int reverse = 0;
                string text2 = "";
                do
                {
                    for (int j = text.Length - 1; j >= 0; j--)
                    {
                        text2 += text[j];
                    }
                    reverse = int.Parse(text2);
                    if (number == reverse)
                        break;
                    how++;
                    number += reverse;
                    text = number.ToString();
                    text2 = "";
                } while (true);
                Console.WriteLine(number + " " + how);
            }
        }
    }
}
