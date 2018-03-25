using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaneDoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listaStudentow = generujListe();

            //wyswietlListe(listaStudentow);

            //var wyszukaj = from m in listaStudentow where m.dataUrodzenia >= new DateTime(1980,1,1) && m.dataUrodzenia >=new DateTime(1980,12,31)  select m;
            //var wyszukaj = from m in listaStudentow where m.dataUrodzenia.Year >= 1980 && m.dataUrodzenia.Year <=1990 select m;
            /*foreach (var item in wyszukaj)
            {
            Console.WriteLine(item.imie + " " + item.dataUrodzenia);
            }*/
            /*var wyszukaj = from m in listaStudentow where m.adres.miasto == "Częstochowa" select m;
            foreach (var item in wyszukaj)
            {
                Console.WriteLine(item.imie + " " + item.adres.miasto);
            }*/

            // Kod zapytań LINQ
            /*var wyszukaj = from m in listaStudentow where m.adres.miasto == "Mikołów" && m.dataUrodzenia.Year == 1994
                           orderby m.nazwisko ascending select m; //descending
            foreach (var item in wyszukaj)
            {
                Console.WriteLine(item.imie + " " + item.nazwisko + " " + item.adres.miasto);
            }*/
            var wyszukaj = from m in listaStudentow where m.imie == "Piotr" select m; // n.adres.miasto
            foreach (var item in wyszukaj) //string miasto in wyszukaj
            {
                Console.WriteLine( item.adres.miasto);
            }
        }

        public static void wyswietlListe(List<Student> listaStudentow)
        {
            foreach (Student student in listaStudentow)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}",
                                     student.studentID,
                                     student.nazwisko,
                                     student.imie,
                                     student.dataUrodzenia.ToLongDateString());
                Console.WriteLine("{0} {1}, ul. {2}", student.adres.kadPocztowy
                                                     , student.adres.miasto
                                                     , student.adres.ulica);
            }
        }

        public static List<Student> generujListe()
        {
           List<Student> lista = new List<Student>();

            lista.Add(new Student(1,
                                  "Abacki",
                                  "Jan",
                                  new DateTime(1996, 11, 11),
                                  new Adres("Klonowa 2/4", "41-100", "Siemianowice Śląskie")));
            lista.Add(new Student(2,
                                  "Bbacki",
                                  "Adam",
                                  new DateTime(1996, 10, 10),
                                  new Adres("Miodowa 2", "43-195", "Mikołów")));
            lista.Add(new Student(3,
                                  "Cbacka",
                                  "Anna",
                                  new DateTime(1995, 1, 10),
                                  new Adres("1 Maja 2/2", "41-200", "Sosnowiec")));
            lista.Add(new Student(4,
                                  "Dbacka",
                                  "Kleopatra",
                                  new DateTime(1994, 5, 5),
                                  new Adres("1 Maja 2/2", "41-300", "Dąbrowa Górnicza")));
            lista.Add(new Student(5,
                                  "Ebacki",
                                  "Szymon",
                                  new DateTime(1994, 9, 15),
                                  new Adres("1000 Lecia Państwa Polskiego	 2/2", "41-400", "Mysłowice")));
            lista.Add(new Student(6,
                                  "Fbacki",
                                  "Piotr",
                                  new DateTime(1990, 9, 15),
                                  new Adres("Astrów	13", "41-500", "Chorzów")));
            lista.Add(new Student(7,
                                 "Gbacki",
                                 "Feliks",
                                 new DateTime(1993, 8, 11),
                                 new Adres("11 Listopada 3/12", "42-100", "Kłobuck")));
            lista.Add(new Student(8,
                                 "Hbacka",
                                 "Ewa",
                                 new DateTime(1987, 8, 11),
                                 new Adres("Drogowców 3/12", "42-200", "Częstochowa")));
            lista.Add(new Student(9,
                                 "Ibacka",
                                 "Ewelina",
                                 new DateTime(1997, 11, 1),
                                 new Adres("3 Maja 3", "42-300", "Myszków")));
            lista.Add(new Student(10,
                                 "Jbacki",
                                 "Patryk",
                                 new DateTime(1993, 3, 3),
                                 new Adres("Amatorska 4", "42-400", "Zawiercie")));
            lista.Add(new Student(11,
                                  "Kbacki",
                                  "Jan",
                                  new DateTime(1994, 11, 11),
                                  new Adres("Klonowa 18", "41-100", "Siemianowice Śląskie")));
            lista.Add(new Student(12,
                                  "Bbacki",
                                  "Paweł",
                                  new DateTime(1994, 1, 14),
                                  new Adres("Pszczela 2", "43-195", "Mikołów")));
            lista.Add(new Student(13,
                                  "Cbacka",
                                  "Anastazja",
                                  new DateTime(1995, 11, 10),
                                  new Adres("1 Maja 2/2", "41-200", "Sosnowiec")));
            lista.Add(new Student(14,
                                  "Mbacka",
                                  "Kleopatra",
                                  new DateTime(1993, 3, 5),
                                  new Adres("1 Maja 2", "41-300", "Dąbrowa Górnicza")));
            lista.Add(new Student(15,
                                  "Ebacki",
                                  "Leon",
                                  new DateTime(1994, 10, 11),
                                  new Adres("Logiczna 2/2", "41-400", "Mysłowice")));
            lista.Add(new Student(16,
                                  "Fbacki",
                                  "Patryk",
                                  new DateTime(1994, 5, 11),
                                  new Adres("Astrów	11", "41-500", "Chorzów")));
            lista.Add(new Student(17,
                                 "Obacki",
                                 "Feliks",
                                 new DateTime(1992, 2, 11),
                                 new Adres("11 Listopada 32", "42-100", "Kłobuck")));
            lista.Add(new Student(18,
                                 "Hbacka",
                                 "Celina",
                                 new DateTime(1987, 2, 14),
                                 new Adres("Smoków 3", "42-200", "Częstochowa")));
            lista.Add(new Student(19,
                                 "Ibacka",
                                 "Ewa",
                                 new DateTime(1993, 11, 1),
                                 new Adres("3 Maja 12/3", "42-300", "Myszków")));
            lista.Add(new Student(20,
                                 "Pbacki",
                                 "Przemysław",
                                 new DateTime(1993, 3, 3),
                                 new Adres("Amatorska 41", "42-400", "Zawiercie")));
            lista.Add(new Student(21,
                                  "Abacki",
                                  "Szymon",
                                  new DateTime(1996, 12, 1),
                                  new Adres("Leśna 2", "41-100", "Siemianowice Śląskie")));
            lista.Add(new Student(22,
                                  "Patryk",
                                  "Adam",
                                  new DateTime(1993, 10, 10),
                                  new Adres("22 lipca 2", "43-195", "Mikołów")));
            lista.Add(new Student(23,
                                  "Kowalska",
                                  "Anna",
                                  new DateTime(1995, 1, 10),
                                  new Adres("3 Maja 2", "41-200", "Sosnowiec")));
            lista.Add(new Student(24,
                                  "Dbacka",
                                  "Sylwia",
                                  new DateTime(1989, 5, 5),
                                  new Adres("1 Maja 333", "41-300", "Dąbrowa Górnicza")));
            lista.Add(new Student(25,
                                  "Abacki",
                                  "Wiesław",
                                  new DateTime(1994, 6, 15),
                                  new Adres("PPS 2/2", "41-400", "Mysłowice")));
            lista.Add(new Student(26,
                                  "Filek",
                                  "Piotr",
                                  new DateTime(1994, 9, 25),
                                  new Adres("Mleczy	3", "41-500", "Chorzów")));
            lista.Add(new Student(27,
                                 "Gil",
                                 "Franciszek",
                                 new DateTime(1992, 3, 13),
                                 new Adres("3 Maja 3/12", "42-100", "Kłobuck")));
            lista.Add(new Student(28,
                                 "Wbacka",
                                 "Ewa",
                                 new DateTime(1983, 8, 11),
                                 new Adres("Gładka 3", "42-200", "Częstochowa")));
            lista.Add(new Student(29,
                                 "Ibacka",
                                 "Zenona",
                                 new DateTime(1992, 1, 1),
                                 new Adres("3 Maja 12", "42-300", "Myszków")));
            lista.Add(new Student(30,
                                 "Zbacki",
                                 "Patryk",
                                 new DateTime(1993, 5, 3),
                                 new Adres("Zawodowa 4", "42-400", "Zawiercie")));
            lista.Add(new Student(31,
                                  "Klipa",
                                  "Jan",
                                  new DateTime(1993, 11, 11),
                                  new Adres("Lipowa 18/3", "41-100", "Siemianowice Śląskie")));
            lista.Add(new Student(32,
                                  "Byk",
                                  "Paweł",
                                  new DateTime(1993, 11, 24),
                                  new Adres("Lesna 2", "43-195", "Mikołów")));
            lista.Add(new Student(33,
                                  "Cygan",
                                  "Anastazja",
                                  new DateTime(1993, 1, 10),
                                  new Adres("11 listopada 2/2", "41-200", "Sosnowiec")));
            lista.Add(new Student(34,
                                  "Gbacka",
                                  "Leokadia",
                                  new DateTime(1981, 3, 5),
                                  new Adres("Wilcza 2", "41-300", "Dąbrowa Górnicza")));
            lista.Add(new Student(35,
                                  "Error",
                                  "Borys",
                                  new DateTime(1993, 10, 11),
                                  new Adres("Zamiejska 22", "41-400", "Mysłowice")));
            lista.Add(new Student(36,
                                  "Filon",
                                  "Wiesław",
                                  new DateTime(1994, 5, 11),
                                  new Adres("Kwiatowa 11", "41-500", "Chorzów")));
            lista.Add(new Student(37,
                                 "Obacki",
                                 "Feliks",
                                 new DateTime(1994, 12, 11),
                                 new Adres("Zielona 2", "42-100", "Kłobuck")));
            lista.Add(new Student(28,
                                 "Wiejska",
                                 "Celina",
                                 new DateTime(1983, 12, 14),
                                 new Adres("Szeroka 3", "42-200", "Częstochowa")));
            lista.Add(new Student(29,
                                 "Iwaniak",
                                 "Patrycja",
                                 new DateTime(1993, 1, 11),
                                 new Adres("Zakosów 12/3", "42-300", "Myszków")));
            lista.Add(new Student(40,
                                 "Kalisz",
                                 "Aleksander",
                                 new DateTime(1994, 4, 4),
                                 new Adres("Inna 44", "42-400", "Zawiercie")));
            lista.Add(new Student(41,
                                  "Antkowiak",
                                  "Jan",
                                  new DateTime(1996, 1, 11),
                                  new Adres("Akacjowa 2/4", "41-100", "Siemianowice Śląskie")));
            lista.Add(new Student(42,
                                  "Nowak",
                                  "Adam",
                                  new DateTime(1993, 10, 15),
                                  new Adres("Nowa 2", "43-195", "Mikołów")));
            lista.Add(new Student(43,
                                  "Antkowiak",
                                  "Jan",
                                  new DateTime(1992, 11, 10),
                                  new Adres("Makowa 2/2", "41-200", "Sosnowiec")));
            lista.Add(new Student(44,
                                  "Klon",
                                  "Kleopatra",
                                  new DateTime(1993, 5, 5),
                                  new Adres("Pszczela 2/2", "41-300", "Dąbrowa Górnicza")));
            lista.Add(new Student(45,
                                  "Wicek",
                                  "Szymon",
                                  new DateTime(1992, 9, 15),
                                  new Adres("Warszawska 2", "41-400", "Mysłowice")));
            lista.Add(new Student(46,
                                  "Fabik",
                                  "Piotr",
                                  new DateTime(1995, 2, 15),
                                  new Adres("Stara	13", "41-500", "Chorzów")));
            lista.Add(new Student(47,
                                 "Głowacki",
                                 "Feliks",
                                 new DateTime(1992, 3, 30),
                                 new Adres("22 lipca 3/12", "42-100", "Kłobuck")));
            lista.Add(new Student(48,
                                 "Wańka",
                                 "Ewa",
                                 new DateTime(1983, 2, 11),
                                 new Adres("Lotników 12", "42-200", "Częstochowa")));
            lista.Add(new Student(49,
                                 "Istabska",
                                 "Ewelina",
                                 new DateTime(1991, 1, 21),
                                 new Adres("Jeziorowa 3", "42-300", "Myszków")));
            lista.Add(new Student(50,
                                 "Kowal",
                                 "Patryk",
                                 new DateTime(1992, 3, 3),
                                 new Adres("Aktorska 4", "42-400", "Zawiercie")));
            lista.Add(new Student(51,
                                  "Zoro",
                                  "Jan",
                                  new DateTime(1994, 11, 11),
                                  new Adres("Kolejowa 8", "41-100", "Siemianowice Śląskie")));
            lista.Add(new Student(52,
                                  "Bałtycki",
                                  "Paweł",
                                  new DateTime(1994, 11, 24),
                                  new Adres("Pszczela 2", "43-195", "Mikołów")));
            lista.Add(new Student(53,
                                  "Klin",
                                  "Anna",
                                  new DateTime(1995, 11, 10),
                                  new Adres("11 listopada 2/2", "41-200", "Sosnowiec")));
            lista.Add(new Student(54,
                                  "Mbacka",
                                  "Aldona",
                                  new DateTime(1991, 11, 5),
                                  new Adres("Solidarności 2", "41-300", "Dąbrowa Górnicza")));
            lista.Add(new Student(55,
                                  "Sikora",
                                  "Leon",
                                  new DateTime(1995, 10, 11),
                                  new Adres("Wiejska 2", "41-400", "Mysłowice")));
            lista.Add(new Student(56,
                                  "Klin",
                                  "Piotr",
                                  new DateTime(1994, 5, 11),
                                  new Adres("Kwiatowa	11", "41-500", "Chorzów")));
            lista.Add(new Student(57,
                                 "Oskarski",
                                 "Feliks",
                                 new DateTime(1995, 2, 11),
                                 new Adres("11 Listopada 42", "42-100", "Kłobuck")));
            lista.Add(new Student(58,
                                 "Wąska",
                                 "Celina",
                                 new DateTime(1987, 2, 14),
                                 new Adres("Smoków 7", "42-200", "Częstochowa")));
            lista.Add(new Student(59,
                                 "Luty",
                                 "Ewa",
                                 new DateTime(1993, 11, 1),
                                 new Adres("3 Maja 3", "42-300", "Myszków")));
            lista.Add(new Student(60,
                                 "Pbacki",
                                 "Piotr",
                                 new DateTime(1995, 1, 23),
                                 new Adres("Amatorska 41", "42-400", "Zawiercie")));
            lista.Add(new Student(61,
                                  "Abacki",
                                  "Piotr",
                                  new DateTime(1990, 2, 1),
                                  new Adres("Leśna 2", "41-100", "Siemianowice Śląskie")));
            lista.Add(new Student(62,
                                  "Witos",
                                  "Adam",
                                  new DateTime(1995, 11, 21),
                                  new Adres("Kijanki 2", "43-195", "Mikołów")));
            lista.Add(new Student(63,
                                  "Kowalska",
                                  "Elwira",
                                  new DateTime(1990, 11, 10),
                                  new Adres("3 Maja 2", "41-200", "Sosnowiec")));
            lista.Add(new Student(64,
                                  "Kartka",
                                  "Jan",
                                  new DateTime(1989, 5, 5),
                                  new Adres("3 Maja 3", "41-300", "Dąbrowa Górnicza")));
            lista.Add(new Student(65,
                                  "Astek",
                                  "Wiesław",
                                  new DateTime(1992, 5, 15),
                                  new Adres("Mickiewicza 3", "41-400", "Mysłowice")));
            lista.Add(new Student(66,
                                  "Filek",
                                  "Szymon",
                                  new DateTime(1992, 9, 25),
                                  new Adres("Mleczy	7", "41-500", "Chorzów")));
            lista.Add(new Student(67,
                                 "Gil",
                                 "Jan",
                                 new DateTime(1990, 8, 13),
                                 new Adres("3 Maja 3/12", "42-100", "Kłobuck")));
            lista.Add(new Student(68,
                                 "Witek",
                                 "Ewa",
                                 new DateTime(1987, 8, 11),
                                 new Adres("Gładka 13", "42-200", "Częstochowa")));
            lista.Add(new Student(69,
                                 "Ziaja",
                                 "Leon",
                                 new DateTime(1995, 11, 21),
                                 new Adres("3 Maja 15", "42-300", "Myszków")));
            lista.Add(new Student(70,
                                 "Klin",
                                 "Wiesława",
                                 new DateTime(1993, 5, 3),
                                 new Adres("Zawodowa 7", "42-400", "Zawiercie")));
            lista.Add(new Student(71,
                                  "Klipa",
                                  "Szymon",
                                  new DateTime(1992, 10, 11),
                                  new Adres("Lipowa 18/3", "41-100", "Siemianowice Śląskie")));
            lista.Add(new Student(72,
                                  "Byk",
                                  "Anna",
                                  new DateTime(1997, 11, 24),
                                  new Adres("Lesna 2", "43-195", "Mikołów")));
            lista.Add(new Student(73,
                                  "Cygan",
                                  "Janina",
                                  new DateTime(1990, 11, 6),
                                  new Adres("11 listopada 2/2", "41-200", "Sosnowiec")));
            lista.Add(new Student(74,
                                  "Głowa",
                                  "Lidia",
                                  new DateTime(1981, 3, 5),
                                  new Adres("Wilcza 22", "41-300", "Dąbrowa Górnicza")));
            lista.Add(new Student(75,
                                  "Błąd",
                                  "Borys",
                                  new DateTime(1997, 3, 11),
                                  new Adres("Kosmiczna 22", "41-400", "Mysłowice")));
            lista.Add(new Student(76,
                                  "Filon",
                                  "Aron",
                                  new DateTime(1990, 8, 11),
                                  new Adres("Kwiatowa 111", "41-500", "Chorzów")));
            lista.Add(new Student(77,
                                 "Obecny",
                                 "Jan",
                                 new DateTime(1998, 12, 11),
                                 new Adres("Zielona 22", "42-100", "Kłobuck")));
            lista.Add(new Student(78,
                                 "Kiepski",
                                 "Jan",
                                 new DateTime(1986, 12, 14),
                                 new Adres("Szeroka 33", "42-200", "Częstochowa")));
            lista.Add(new Student(79,
                                 "Iwaniak",
                                 "Piotr",
                                 new DateTime(1990, 11, 11),
                                 new Adres("Zakosów 12/3", "42-300", "Myszków")));
            lista.Add(new Student(80,
                                 "Kalisz",
                                 "Aanna",
                                 new DateTime(1991, 8, 8),
                                 new Adres("Inna 44", "42-400", "Zawiercie")));

            return lista;

        }
        
    }
}
