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
                x++;
            }
            Console.Write(x);
        }
    }
}
