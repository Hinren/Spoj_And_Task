using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp112
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia, wycinek;
            string[] tab;
            int wyraz = 0, cyfry = 0, ascii;
            while ((linia = Console.ReadLine()) != null)
            {
                wyraz = 0;
                cyfry = 0;
                tab = linia.Split(' ');
                for (int i = 0; i < tab.Length; i++)
                {
                    wycinek = tab[i];
                    ascii = (int)wycinek[0];
                    if ((ascii >= 65 && ascii <= 90) || (ascii >= 97 && ascii <= 122))
                        wyraz++;
                    else if (ascii >= 48 && ascii <= 57)
                        cyfry++;
                }
                Console.WriteLine("{0} {1}", cyfry, wyraz);
            }
        }
    }
}
