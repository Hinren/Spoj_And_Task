using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc_prob;
            string linia;
            ilosc_prob = int.Parse(Console.ReadLine());
            for (int i = 0; i < ilosc_prob; i++)
            {
                linia = Console.ReadLine();
                if (linia.Length == 8)
                {
                    int dzien_l = int.Parse(linia.Substring(0, 2));
                    int miesiac_l = int.Parse(linia.Substring(2, 2));
                    int rok_l = int.Parse(linia.Substring(4, 4));
                    if ((miesiac_l > 0 && miesiac_l <= 12) && dzien_l > 0 && (rok_l >= 1000 && rok_l <= 2200))
                    {
                        if ((miesiac_l == 1 || miesiac_l == 3 || miesiac_l == 5 || miesiac_l == 7
                        || miesiac_l == 8 || miesiac_l == 10 || miesiac_l == 12) && dzien_l <= 31 )
                        {
                            if (miesiac_l == 1)
                                Console.WriteLine("{0} stycznia {1}", dzien_l, rok_l);
                            if (miesiac_l == 3)
                                Console.WriteLine("{0} marca {1}", dzien_l, rok_l);
                            if (miesiac_l == 5)
                                Console.WriteLine("{0} maja {1}", dzien_l, rok_l);
                            if (miesiac_l == 7)
                                Console.WriteLine("{0} lipca {1}", dzien_l, rok_l);
                            if (miesiac_l == 8)
                                Console.WriteLine("{0} sierpnia {1}", dzien_l, rok_l);
                            if (miesiac_l == 10)
                                Console.WriteLine("{0} pazdziernika {1}", dzien_l, rok_l);
                            if (miesiac_l == 12)
                                Console.WriteLine("{0} grudnia {1}", dzien_l, rok_l);
                        }
                        else if ((miesiac_l == 4 || miesiac_l == 6 || miesiac_l == 9 || miesiac_l == 11) && dzien_l <= 30)
                        {
                            if (miesiac_l == 4)
                                Console.WriteLine("{0} kwietnia {1}", dzien_l, rok_l);
                            if (miesiac_l == 6)
                                Console.WriteLine("{0} czerwca {1}", dzien_l, rok_l);
                            if (miesiac_l == 9)
                                Console.WriteLine("{0} wrzesnia {1}", dzien_l, rok_l);
                            if (miesiac_l == 11)
                                Console.WriteLine("{0} listopada {1}", dzien_l, rok_l);
                        }
                        else if (miesiac_l == 2)
                        {
                            if (rok_l % 4 == 0 && rok_l % 100 != 0 || rok_l % 400 == 0)
                            {
                                if (dzien_l <= 29)
                                    Console.WriteLine("{0} lutego {1}", dzien_l, rok_l);
                                else
                                    Console.WriteLine("niepoprawny format daty");
                            }
                            else
                            {
                                if (dzien_l <= 28)
                                    Console.WriteLine("{0} lutego {1}", dzien_l, rok_l);
                                else
                                    Console.WriteLine("niepoprawny format daty");
                            }
                        }
                        else
                            Console.WriteLine("niepoprawny format daty");
                    }
                    else
                        Console.WriteLine("niepoprawny format daty");
                }
                else
                    Console.WriteLine("niepoprawny format daty");
            }
        }
    }
}
