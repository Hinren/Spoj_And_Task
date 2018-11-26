using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma = 0;
            string linia;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                suma = 0;
                linia = Console.ReadLine();
                if (linia.Length == 11)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (j == 0 || j == 4 || j == 8 || j == 10)
                        {
                            suma = suma + (Convert.ToInt32(linia[j])) * 1;
                        }
                        if (j == 1 || j == 5 || j == 9)
                        {
                            suma = suma + (Convert.ToInt32(linia[j])) * 3;
                        }
                        if (j == 2 || j == 6)
                        {
                            suma = suma + (Convert.ToInt32(linia[j])) * 7;
                        }
                        if (j == 3 || j == 7)
                        {
                            suma = suma + (Convert.ToInt32(linia[j])) * 9;
                        }
                    }
                    if (suma % 10 == 0)
                    {
                        Console.WriteLine("D");
                    }
                    else
                    {
                        Console.WriteLine("N");
                    }
                }
            }
        }
    }
}
