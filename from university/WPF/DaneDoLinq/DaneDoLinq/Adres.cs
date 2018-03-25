using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaneDoLinq
{
    class Adres
    {
        public string ulica { get; set; }
        public string kadPocztowy { get; set; }
        public string miasto { get; set; }

        public Adres(string u, string k, string m)
        {
            ulica = u;
            kadPocztowy = k;
            miasto = m;
        }
    }
}
