using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp112
{
    class Program
    {
        const int Ilosc_liter = 26;

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string linia = sr.ReadLine();
            int[] tablica = new int[Ilosc_liter];
            int LiteryWLinii = 0;
            for (int i = 0; i < linia.Length; i++)
            {
                if (Char.IsUpper(linia[i]))
                {
                    tablica[linia[i] - 'A']++;
                    LiteryWLinii++;
                }
            }
            for (int i = 0; i < Ilosc_liter; i++)
            {
                sw.WriteLine((char)(65 + i) + new string('*', liczba_Gwiazdek(tablica[i], LiteryWLinii)));
            }

            sr.Close();
            sw.Flush();
            sw.Close();

        }
        static int liczba_Gwiazdek(int x, int y)
        {
            return (int)Math.Round(((double)x / y) * 100);
        }
    }
}
