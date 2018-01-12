using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string linia;
            while ((linia = Console.ReadLine()) != null)
            {
                for (int i = 0; i < linia.Length; i++)
                {
                    x = (int)linia[i];
                    if (x == 88)
                        x = 65;
                    else if (x == 89)
                        x = 66;
                    else if (x == 90)
                        x = 67;
                    else if (x == 32)
                        x = 32;
                    else
                        x = x + 3;

                    char test2 = (char)x;
                    Console.Write(test2);
                }
                Console.WriteLine("");
            }
        }
    }
}
