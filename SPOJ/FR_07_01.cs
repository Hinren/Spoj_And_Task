using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp115
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] tab;
            string linia_2 = "";
            for (int i = 0; i < n; i++)
            {
                linia_2 = "";
                string linia = Console.ReadLine();
                for (int j = linia.Length; j > 0; j--)
                {
                    linia_2 += linia[j - 1];
                }
                tab = linia_2.Split(' ');
                int a = int.Parse(tab[0]);
                int b = int.Parse(tab[1]);
                if (a > b)
                    Console.WriteLine(a);
                else
                    Console.WriteLine(b);
            }
        }
    }
}
