using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rowkwa
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal delta, wynik = 0;
            string nazwa;
            while ((nazwa = Console.ReadLine()) != null)

            {

                nazwa = nazwa.Replace('.', ',');

                string[] tab;
                tab = nazwa.Split(' ');




                decimal[] dec = new decimal[3];
                for (int z = 0; z < dec.Length; z++)
                {
                    dec[z] = decimal.Parse(tab[z]);
                }


                if (dec[0] != 0)
                {
                    decimal a = dec[0];
                    decimal b = dec[1];
                    decimal c = dec[2];
                    decimal inne = 4 * a * c;
                    delta = (b * b) - inne;
                    if (delta == 0)
                    {
                        wynik = 1;
                    }
                    else if (delta > 0)
                    {
                        wynik = 2;
                    }
                    else wynik = 0;


                }
                Console.WriteLine(wynik);
            }
            Console.ReadKey();

        }
    }
}
