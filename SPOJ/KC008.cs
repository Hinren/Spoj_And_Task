using System;

namespace ConsoleApp118
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia;
            string[] tab;
            long suma = 0, suma_koncowa = 0;
            while ((linia = Console.ReadLine()) != null)
            {
                suma = 0;
                tab = linia.Split();
                for (int i = 0; i < tab.Length; i++)
                {
                    suma += long.Parse(tab[i]);
                }
                suma_koncowa += suma;
                Console.WriteLine(suma);
            }
            Console.WriteLine(suma_koncowa);
        }
    }
}
