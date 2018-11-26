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
                        Console.WriteLine(":)");
                        
                        licznik++;
                    }
                    else
                        Console.WriteLine(":(");
                }
                if (linia == "-")
                {
                    if (licznik > 0)
                    {
                        licznik--;
                        Console.WriteLine(tab[licznik]);
                    }
                    else Console.WriteLine(":(");
                }
            }
            Console.ReadKey();
        }
    }
}
