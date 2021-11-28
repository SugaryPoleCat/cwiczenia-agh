using System;

namespace CW3_1
{
    enum Plcie { M, K }
    [Serializable]
    abstract class Osoba : IEquatable<Osoba>
    {
        string imie;
        string nazwisko;
        DateTime dataUrodzenia;
        string pESEL;
        Plcie plec;

        public string Imie { get => Imie; }
        public string Nazwisko { get => Nazwisko; }

        public DateTime DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }
        public string PESEL
        {
            get => pESEL;
            set
            {
                if (!SprawdzPesel(value))
                {
                    throw new FormatException("Niepoprawny format PESELa");
                }
                pESEL = value;
            }
        }

        public Osoba()
        {
            PESEL = new string('0', 11);
        }
        public Osoba(string imie, string nazwisko) : this()
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        protected Osoba(string imie, string nazwisko, string dataUrodzenia,
            string pESEL, Plcie plec) : this(imie, nazwisko)
        {
            DateTime.TryParseExact(dataUrodzenia,
                new string[] { "dd-MM-yyyy" }, null, System.Globalization.DateTimeStyles.None, out this.dataUrodzenia);
            this.pESEL = pESEL;
            this.plec = plec;
        }

        public int Wiek()
        {
            int w = (int)((DateTime.Now - DataUrodzenia).TotalDays / 365.0);
            return Math.Max(w, 0);
        }
        public bool SprawdzPesel(string s)
        {
            //    Regex r = new Regex(@"\d{11}");
            return true;
        }
        public override string ToString()
        {
            return $"{imie} {nazwisko} (ur. {DataUrodzenia:dd/MM/yyyy}, w: {Wiek()}), PESEL: {PESEL}";
        }

        public bool Equals(Osoba other)
        {
            return PESEL.Equals(other.PESEL);
        }
    }
}
