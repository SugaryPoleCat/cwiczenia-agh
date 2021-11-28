using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CW3_1
{
    interface IZapisywalna
    {
        void ZapiszBIN(string filename);
    }
    class PESELComparator : IComparer<CzlonekZespolu>
    {
        public int Compare(CzlonekZespolu x, CzlonekZespolu y)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(CzlonekZespolu x, CzlonekZespolu y)
        {
            return x.PESEL.CompareTo(y.PESEL);
        }
    }

    [Serializable]
    class Zespol : ICloneable, IZapisywalna
    {
        private string nazwa;
        private KierownikZespolu kierownik;
        private List<CzlonekZespolu> czlonkowie;
        public KierownikZespolu

        public Zespol()
        {
            czlonkowie = new List<CzlonekZespolu>();
        }

        public Zespol(string nazwa, KierownikZespolu kierownik) : this()
        {
            this.nazwa = nazwa;
            this.kierownik = kierownik;
        }

        public void DodajCzlonkaZespolu(CzlonekZespolu cz)
        {
            if (cz is null) { return; }
            czlonkowie.Add(cz);
        }

        public bool JestCzlonkiemZespolu(string pesel)
        {
            return czlonkowie.Where(cz => cz.PESEL.Equals(pesel)).Any();
        }
        public bool JestCzlonkiemZespolu(string imie, string nazwisko)
        {
            return czlonkowie.Where(cz => cz.Imie.Equals(imie) && cz.Nazwisko.Equals(nazwisko)).Any();
        }

        public bool JestCzlonkiemZespolu(CzlonekZespolu cz)
        {
            return czlonkowie.Where(c => c.Equals(cz)).Any();
        }

        public void UsunCzlonka(string pesel)
        {
            CzlonekZespolu cz = czlonkowie.FirstOrDefault(czl => czl.PESEL.Equals(pesel));
            czlonkowie.Remove(cz);
        }

        public void UsunCzlonka(string imie, string nazwisko)
        {
            CzlonekZespolu cz = czlonkowie.FirstOrDefault(cz1 => cz1.Imie.Equals(imie));
            // tu musi znalesc czlonka za pomoca podania Imienia i nazwiska w jednym.
            czlonkowie.Remove(cz);
        }

        public void UsunWszystkich()
        {
            czlonkowie.Clear();
        }

        public List<CzlonekZespolu> WyszukajFunkcje(string funkcja)
        {
            // return czlonkowie.Where(cz => cz.Funkcja.Equals(funkcja)).ToList();
            return czlonkowie.FindAll(cz => cz.Funkcja.Equals(funkcja));
        }

        public void SortujCzlonkowZespolu()
        {
            // czlonkowie.Sort();
            czlonkowie.Sort((cz1, cz2) => cz1.Nazwisko.CompareTo(cz2.Nazwisko));
        }

        public void SortujPoPESEL()
        {
            czlonkowie.Sort(new PESELComparator());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Zespol: {nazwa}");
            sb.AppendLine($"Kierownik: {kierownik}");
            sb.AppendLine("Czlonkowie zespolu:");
            // foreach(CzlonekZespolu cz in czlonkowie)
            //{
            //    sb.AppendLine(cz.ToString());
            //}
            czlonkowie.ForEach(cz => sb.AppendLine(cz.ToString()));
            return sb.ToString();
        }

        public object Clone()
        {
            Zespol kopia = this.MemberwiseClone() as Zespol;
            kopia.kierownik = kierownik.Clone() as KierownikZespolu;
            kopia.czlonkowie = new List<CzlonekZespolu>();
            czlonkowie.ForEach(cz => kopia.DodajCzlonkaZespolu(cz.Clone() as CzlonekZespolu));
            return kopia;
        }

        public static Zespol OdczytBIN(string filename)
        {
            BinaryFormatter bf = new BinaryFormatter();
            if (!File.Exists(filename))
            {
                return null;
            }
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                return bf.Deserialize(fs) as Zespol;
            }
        }

        public void ZapiszBIN(string filename)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                bf.Serialize(fs, this);
            }
        }

        // create zapiszxml and odczytajxml taht will write and read the xml file of the person.
    }
    [Serializable]
    class CzlonekZespolu : Osoba, IComparable<CzlonekZespolu>, ICloneable
    {
        string funkcja;
        public string Funkcja { get => funkcja; }
        public CzlonekZespolu() : base() { }
        public CzlonekZespolu(string imie, string nazwisko, string funkcja) : base(imie, nazwisko)
        {
            this.funkcja = funkcja;
        }
        //[Serializable]
        public CzlonekZespolu(string imie, string nazwisko, string dataUrodzenia,
            string pESEL, Plcie plec, string funkcja)
            : base(imie, nazwisko, dataUrodzenia, pESEL, plec)
        {
            this.funkcja = funkcja;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {funkcja}";
        }

        public int CompareTo(CzlonekZespolu other)
        {
            if (other is null)
            {
                return 1;
            }
            int w = Nazwisko.CompareTo(other.Nazwisko);
            if (w != 0)
            {
                return w;
            }
            return Imie.CompareTo(other.Imie);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
    [Serializable]
    class KierownikZespolu : Osoba, ICloneable
    {
        int doswiadczenie;
        public KierownikZespolu() : base() { }
        public KierownikZespolu(string imie, string nazwisko, int doswiadczenie) : base(imie, nazwisko)
        {
            this.doswiadczenie = doswiadczenie;
        }
        public KierownikZespolu(string imie, string nazwisko, string dataUrodzenia,
            string pESEL, Plcie plec, int doswiadczenie) : base(imie, nazwisko, dataUrodzenia, pESEL, plec)
        {
            this.doswiadczenie = doswiadczenie;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {doswiadczenie}";
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        //[Serializable];
    }
        
}
