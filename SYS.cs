using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp107
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int liczba, liczba2, reszta = 0, wynik = 0;
            string wynik_szsna = "", wynik_jede = "";
            for (int i = 0; i < n; i++)
            {
                wynik_jede = "";
                wynik_szsna = "";
                liczba = int.Parse(Console.ReadLine());
                liczba2 = liczba;
                for (int j = 0; j < 50; j++)
                {
                    reszta = liczba % 16;
                    if (reszta == 15)
                        wynik_szsna += "F";
                    if (reszta == 14)
                        wynik_szsna += "E";
                    if (reszta == 13)
                        wynik_szsna += "D";
                    if (reszta == 12)
                        wynik_szsna += "C";
                    if (reszta == 11)
                        wynik_szsna += "B";
                    if (reszta == 10)
                        wynik_szsna += "A";
                    if (reszta < 10)
                        wynik_szsna += reszta;

                    wynik = liczba / 16;

                    if (wynik == 0)
                        break;
                    else
                        liczba = wynik;
                }
                for (int j = 0; j < 50; j++)
                {
                    reszta = liczba2 % 11;
                    if (reszta == 10)
                        wynik_jede += "A";
                    if (reszta < 10)
                        wynik_jede += reszta;

                    wynik = liczba2 / 11;

                    if (wynik == 0)
                        break;
                    else
                        liczba2 = wynik;
                }
                string wynik_szsna_Koniec = "", wynik_jede_Koniec = "";
                for (int m = wynik_szsna.Length; m > 0; m--)
                {
                    wynik_szsna_Koniec += wynik_szsna[m - 1];
                }
                for (int m = wynik_jede.Length; m > 0; m--)
                {
                    wynik_jede_Koniec += wynik_jede[m - 1];
                }
                Console.WriteLine("{0} {1}", wynik_szsna_Koniec, wynik_jede_Koniec);
            }
            Console.ReadKey();
        }
    }
}
