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
            string linia;
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma = 0;
                linia = Console.ReadLine();
                for (int j = 1; j < linia.Length; j++)
                {
                    if (j == 1)
                    {
                        suma = linia[0] - 48;
                    }
                    if (j - 1 == linia.Length)
                    {
                        break;
                    }
                    else
                    {
                        if (linia[j] == '-')
                            suma -= linia[j + 1] - 48;
                        if (linia[j] == '+')
                            suma += linia[j + 1] - 48;
                    }
                }
                Console.WriteLine(suma);
            }
            Console.ReadKey();
        }
    }
}
