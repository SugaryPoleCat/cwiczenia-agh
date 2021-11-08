using System;
using System.Globalization;

namespace Zadanie_1
{
    enum Plcie
    {
        K, M
    }
    class Osoba
    {
        private string imie;
        public string Nazwisko { get; set; }
        private DateTime dataUrodzenia;
        private string PESEL;
        private Plcie plec;

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }
        public string Pesel
        {
            get { return PESEL; }
            set { PESEL = value; }
        }
        Osoba()
        {

        }
        Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
        Osoba(string imie, string nazwisko, string data_urodzenia, string pesel, Plcie plec)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            DateTime.TryParseExact(data_urodzenia, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy" }, null, DateTimeStyles.None, out dataUrodzenia);
            Pesel = pesel;
            this.plec = plec;
        }
        /*override string ToString()
        {

        }
        int Wiek() { }
        */
    }
}
