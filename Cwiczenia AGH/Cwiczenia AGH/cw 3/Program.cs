using System;
using System.Collections.Generic;

namespace CW3_1
{
    class Program
    {
        static void TestZespolu()
        {
            //Osoba os = new Osoba();
            CzlonekZespolu cz1 =
                new CzlonekZespolu("Adam", "Nowak", "12-03-1995",
                "44444444444", Plcie.M, "programista");
            // Console.WriteLine(cz1);
            KierownikZespolu kier =
                new KierownikZespolu("Zenon", "Muzyk", "22-11-1985",
                "99999999999", Plcie.M, 10);
            CzlonekZespolu cz2 =
                new CzlonekZespolu("Maciej", "Kowalski", "12-03-1995",
                "54623654236", Plcie.M, "elektryk");
            //Console.WriteLine(kier);
            CzlonekZespolu cz3 =
                new CzlonekZespolu("Anna", "Mysza", "12-03-1995",
                "91072235964", Plcie.K, "projektant");
            CzlonekZespolu cz4 =
                new CzlonekZespolu("Beata", "Nowak", "12-03-1993",
                "93112225023", Plcie.K, "projektant");
            Zespol z = new Zespol("FajnyZespol", kier);
            z.DodajCzlonkaZespolu(cz1);
            z.DodajCzlonkaZespolu(cz2);
            z.DodajCzlonkaZespolu(cz3);
            z.DodajCzlonkaZespolu(cz4);
            List<CzlonekZespolu> fz = z.WyszukajFunkcje("projektant");
            fz.ForEach(cz => Console.WriteLine(cz));
            z.SortujCzlonkowZespolu();
            Console.WriteLine(z);
            CzlonekZespolu cz1kopia = cz1.Clone() as CzlonekZespolu;
            //CzlonekZespolu cz1kopia = (CzlonekZespolu)cz1.Clone();
            Console.WriteLine(cz1);
            Console.WriteLine(cz1kopia);
            //Console.WriteLine(z);
            //Console.WriteLine(z.JestCzlonkiemZespolu("93112225023"));
            Zespol zkopia = z.Clone() as Zespol;
            z.SortujPoPESEL();
            Console.WriteLine(z);
            z.ZapiszBIN("test_zapisu.bin");
            Zespol zz = Zespol.OdczytBIN("test_zapisy.bin");
            Console.WriteLine(zz);
        }
        static void Main()
        {
            TestZespolu();
        }
    }
}
