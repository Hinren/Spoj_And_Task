using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10000];
            Random rnd1 = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd1.Next(0, 10000);
            }
            //var liczby = from m in tab where (m > 5000 && m < 5100) || (m > 6000 && m < 6100) select m;
            /*var liczby = from m in tab where m > 100 && m < 200 select m;
             */
            var liczby = from m in tab where m > 4000 && m < 5000 select m;
            //foreach (int i in liczby)
            //{
            //Console.Write(i + ", ");
            //}
            Console.Write(liczby.Count());
            Console.ReadKey();
        }
    }
}
