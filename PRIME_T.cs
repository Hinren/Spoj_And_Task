using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczby_pierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ta = new List<int>();
            string y;
            int n;
            int spr;

            n = Convert.ToInt32(Console.ReadLine());
            if (n < 100000)
            {
                for (int i = 0; i < n; i++)
                {
                    y = Console.ReadLine();
                    if ((int.Parse(y)) >= 1 && (int.Parse(y)) <= 10000)
                    {
                        int wart = (int.Parse(y));
                        ta.Add(wart);
                    }

                }

            }




            foreach (int item in ta)
            {
                spr = 0;

                for (int z = 1; z <= item; z++)
                {
                    if (item % z == 0)
                    {
                        spr++;
                    }

                }

                if (spr == 2)
                {
                    Console.WriteLine("TAK");
                }
                else
                {
                    Console.WriteLine("NIE");
                }


            }

            Console.ReadKey();
        }
    }
}

