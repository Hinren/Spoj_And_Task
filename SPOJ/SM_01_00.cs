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
            int n = int.Parse(Console.ReadLine());
            string linia = "";
            int m = 0, y = 0, kod_ascii = 0;
            for (int i = 0; i < n; i++)
            {
                m = 0;
                y = 0;
                linia = Console.ReadLine();
                string[] tabInt = new string[linia.Length / 5];
                for (int j = 0; j < linia.Length; j++)
                {
                    if (m == 5)
                    {
                        m = 0;
                        y++;
                    }
                    tabInt[y] += linia[j];
                    m++;
                }
                for (int j = 0; j < tabInt.Length; j++)
                {
                    kod_ascii += ((tabInt[j][0] - 48) * (2 * 2 * 2 * 2)) + ((tabInt[j][1] - 48) * (2 * 2 * 2)) +
                        ((tabInt[j][2] - 48) * (2 * 2)) + ((tabInt[j][3] - 48) * 2)
                        + ((tabInt[j][4] - 48) * 1) + 65;
                    char test2 = (char)kod_ascii;
                    kod_ascii = 0;
                    Console.Write(test2);
                }
                Console.WriteLine("");
                Console.ReadKey();
            }

        }
    }
}
