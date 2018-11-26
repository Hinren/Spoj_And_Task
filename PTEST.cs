using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp94
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, suma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x < 200 && y < 200)
            {
                suma = x + y;
                Console.WriteLine(suma);
                Console.ReadKey();
            }
        }
    }
}
