using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaneDoLinq
{
    class Student
    {
        public int studentID { get; set; }
        public string nazwisko { get; set; }
        public string imie { get; set; }
        public DateTime dataUrodzenia { get; set; }
        public Adres adres { get; set; }

        public Student(int id, string n, string i, DateTime du, Adres a)
        {
            studentID = id;
            nazwisko = n;
            imie = i;
            dataUrodzenia = du;
            adres = a;
        }
    }
}
