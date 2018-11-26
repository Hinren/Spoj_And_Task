using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp97
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia;
            int licznik = 0;
            int[] tab = new int[10];
            while ((linia = Console.ReadLine()) != null)
            {
                if (linia == "+")
                {
                    if (licznik < 10)
                    {
                        tab[licznik] = int.Parse(Console.ReadLine());
                        Console.Write(":)");
                        licznik++;
                    }
                    else
                        Console.Write(":(");
                }
                if (linia == "-")
                {
                    if (licznik >= 0)
                    {
                        licznik--;
                        Console.Write(tab[licznik]);
                    }
                    else Console.Write(":(");
                }
            }
            Console.ReadKey();
        }
    }
}
