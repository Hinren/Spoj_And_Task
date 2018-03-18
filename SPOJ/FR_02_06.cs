using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia;
            string[] tab;
            int ilosc_prob;
            ilosc_prob = int.Parse(Console.ReadLine());
            string[,] osoby = new string[2,ilosc_prob];
            Double bmi;
            Double waga, wzrost;
            for (int i = 0; i < ilosc_prob; i++)
            {
                linia = Console.ReadLine();
                tab = linia.Split();
                osoby[0, i] = tab[0];
                waga = Double.Parse(tab[1]);
                wzrost = Double.Parse(tab[2]);
                bmi = waga / ((wzrost / 100)* (wzrost / 100));
                if (bmi < 18.5)
                    osoby[1, i] = "niedowaga";
                if(bmi >= 18.5 && bmi < 25)
                    osoby[1, i] = "wartosc prawidlowa";
                if(bmi >= 25)
                    osoby[1, i] = "nadwaga";

            }
            Console.WriteLine("niedowaga");
            for (int i = 0; i < ilosc_prob; i++)
            {
                if (osoby[1, i] == "niedowaga")
                    Console.WriteLine(osoby[0, i]);
            }
            Console.WriteLine();
            Console.WriteLine("wartosc prawidlowa");
            for (int i = 0; i < ilosc_prob; i++)
            {
                if (osoby[1, i] == "wartosc prawidlowa")
                    Console.WriteLine(osoby[0, i]);
            }
            Console.WriteLine();
            Console.WriteLine("nadwaga");
            for (int i = 0; i < ilosc_prob; i++)
            {
                if (osoby[1, i] == "nadwaga")
                    Console.WriteLine(osoby[0, i]);
            }
        }
    }
}
