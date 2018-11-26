using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, suma = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                suma = 0;
                m = int.Parse(Console.ReadLine());
                suma = m * m;
                Console.WriteLine(suma);
            }
        }
    }
}
