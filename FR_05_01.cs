using System;
namespace ConsoleApp118
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string linia;
            string[] tab;
            int licznik = 0, Licznik_koniec = 0;
            for (int i = 0; i < n; i++)
            {
                linia = Console.ReadLine();
                tab = linia.Split();
                if (tab[0] == "Pn") licznik = 1;
                else if (tab[0] == "Wt") licznik = 2;
                else if (tab[0] == "Sr") licznik = 3;
                else if (tab[0] == "Cz") licznik = 4;
                else if (tab[0] == "Pt") licznik = 5;
                else if (tab[0] == "So") licznik = 6;
                else if (tab[0] == "Nd") licznik = 7;

                Licznik_koniec = (licznik + int.Parse(tab[1])) % 7;

                if (Licznik_koniec == 0) Console.WriteLine("Nd");
                else if (Licznik_koniec == 1) Console.WriteLine("Pn");
                else if (Licznik_koniec == 2) Console.WriteLine("Wt");
                else if (Licznik_koniec == 3) Console.WriteLine("Sr");
                else if (Licznik_koniec == 4) Console.WriteLine("Cz");
                else if (Licznik_koniec == 5) Console.WriteLine("Pt");
                else if (Licznik_koniec == 6) Console.WriteLine("So");
            }
        }
    }
}