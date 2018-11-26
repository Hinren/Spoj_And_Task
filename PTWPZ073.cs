using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp107
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string linia, wyjscie = "";
            for (int i = 0; i < n; i++)
            {
                wyjscie = "";
                linia = Console.ReadLine();
                for (int j = 0; j < linia.Length; j++)
                {
                    if (linia[j] == 'A' || linia[j] == 'B' || linia[j] == 'C')
                        wyjscie += 2;
                    if (linia[j] == 'D' || linia[j] == 'E' || linia[j] == 'F')
                        wyjscie += 3;
                    if (linia[j] == 'G' || linia[j] == 'H' || linia[j] == 'I')
                        wyjscie += 4;
                    if (linia[j] == 'J' || linia[j] == 'K' || linia[j] == 'L')
                        wyjscie += 5;
                    if (linia[j] == 'M' || linia[j] == 'N' || linia[j] == 'O')
                        wyjscie += 6;
                    if (linia[j] == 'P' || linia[j] == 'Q' || linia[j] == 'R' || linia[j] == 'S')
                        wyjscie += 7;
                    if (linia[j] == 'T' || linia[j] == 'U' || linia[j] == 'V')
                        wyjscie += 8;
                    if (linia[j] == 'W' || linia[j] == 'X' || linia[j] == 'Y' || linia[j] == 'Z')
                        wyjscie += 9;
                }
                Console.WriteLine(wyjscie);
            }
            Console.ReadKey();
        }
    }
}
