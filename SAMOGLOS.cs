using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string linia;
            linia = Console.ReadLine();
            for (int i = 0; i < linia.Length; i++)
            {
                if (linia[i] == 'A' || linia[i] == 'E' || linia[i] == 'Y'
                    || linia[i] == 'U' || linia[i] == 'I' || linia[i] == 'O'
                    || linia[i] == 'Ó' || linia[i] == 'Ą' || linia[i] == 'Ę')
                    Console.Write(linia[i]);
            }
        }
    }
}
