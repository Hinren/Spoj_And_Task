using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp105
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia;
            while ((linia = Console.ReadLine()) != null)
            {
                string litera, znaki;
                string[] tab;
                tab = linia.Split(' ');

                litera = tab[0];
                znaki = tab[1];
                for (int j = 0; j < znaki.Length; j++)
                {
                    int m = (int)linia[0];
                    int n = (int)znaki[j];
                    if (n != m)
                    {
                        Console.Write(znaki[j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


