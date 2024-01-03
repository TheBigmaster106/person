using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektowanie
{
     class person
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Plec { get; set; }
        public DateTime DataUrodzenia { get; set; }

        // Konstruktor
        public person(string imie, string nazwisko, string plec, DateTime dataUrodzenia)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Plec = plec;
            DataUrodzenia = dataUrodzenia;
        }

        // Metoda do wyświetlania informacji o osobie
        public override string ToString()
        {
            return $"person: {Imie} {Nazwisko}\nPłeć: {Plec}\nData urodzenia: {DataUrodzenia.ToShortDateString()}";
        }
    }
}
