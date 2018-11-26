using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp106
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia = Console.ReadLine();
            int rok = 0;
            for (int i = 0; i < linia.Length; i++)
            {
                if (linia[i] == 'a' || linia[i] == 'A')
                    rok = rok + 1;
                else if (linia[i] == 'b' || linia[i] == 'B')
                    rok = rok + 2;
                else if (linia[i] == 'c' || linia[i] == 'C')
                    rok = rok + 3;
                else if (linia[i] == 'd' || linia[i] == 'D')
                    rok = rok + 4;
                else if (linia[i] == 'e' || linia[i] == 'E')
                    rok = rok + 5;
                else if (linia[i] == 'f' || linia[i] == 'F')
                    rok = rok + 6;
                else if (linia[i] == 'g' || linia[i] == 'G')
                    rok = rok + 7;
                else if (linia[i] == 'h' || linia[i] == 'H')
                    rok = rok + 8;
                else if (linia[i] == 'i' || linia[i] == 'I')
                    rok = rok + 9;
                else if (linia[i] == 'k' || linia[i] == 'K')
                    rok = rok + 10;
                else if (linia[i] == 'l' || linia[i] == 'L')
                    rok = rok + 20;
                else if (linia[i] == 'm' || linia[i] == 'M')
                    rok = rok + 30;
                else if (linia[i] == 'n' || linia[i] == 'N')
                    rok = rok + 40;
                else if (linia[i] == 'o' || linia[i] == 'O')
                    rok = rok + 50;
                else if (linia[i] == 'p' || linia[i] == 'P')
                    rok = rok + 60;
                else if (linia[i] == 'q' || linia[i] == 'Q')
                    rok = rok + 70;
                else if (linia[i] == 'r' || linia[i] == 'R')
                    rok = rok + 80;
                else if (linia[i] == 's' || linia[i] == 'S')
                    rok = rok + 90;
                else if (linia[i] == 't' || linia[i] == 'T')
                    rok = rok + 100;
                else if (linia[i] == 'v' || linia[i] == 'V')
                    rok = rok + 200;
                else if (linia[i] == 'x' || linia[i] == 'X')
                    rok = rok + 300;
                else if (linia[i] == 'y' || linia[i] == 'Y')
                    rok = rok + 400;
                else if (linia[i] == 'z' || linia[i] == 'Z')
                    rok = rok + 500;
            }
            Console.WriteLine(rok);
            Console.ReadKey();
        }
    }
}
