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
            string linia;
            int suma = 0;
            while ((linia = Console.ReadLine()) != null)
            {
                suma = suma + int.Parse(linia);
                Console.WriteLine(suma);
            }
        }
    }
}
