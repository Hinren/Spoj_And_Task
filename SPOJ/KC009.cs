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
            string linia;
            while ((linia = Console.ReadLine()) != null)
            {
                for (int i = linia.Length; 0 < i; i--)
                {
                    Console.Write(linia[i - 1]);
                }
                Console.WriteLine("");
            }
        }
    }
}
