using System;
using System.Linq;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile = 0;    // Ile liczb uzywtkonik chce
            bool toLiczba = false;  // to zmieni sie jezeli uzytkownik wpisze liczbe. Inicjalnie: false.
            Console.WriteLine("Podaj ile liczb chcesz: ");
            while (!toLiczba)   // w tym przypadku lepszy by byl do{}while();
            {
                toLiczba = int.TryParse(Console.ReadLine(), out ile);   // proboj wkleic INPUT z CONSOLE jako int.
                // Jezeli sie uda, ustaw ILE, czyli to out.
                // jezeli nie udalo sie, to "t
                if (!toLiczba)
                {
                    Console.WriteLine("Podaj liczbe ponownie");
                }
            }

            int[] arrLiczb = new int[ile];

            for (int x = 0; x < arrLiczb.Length; x++)
            {
                toLiczba = false;
                int liczba = 0;
                Console.WriteLine("Podaj liczbe na pozycje: " + (x + 1) + "/" + ile);
                while (!toLiczba)
                {
                    toLiczba = int.TryParse(Console.ReadLine(), out liczba);
                    if (!toLiczba)
                    {
                        Console.WriteLine("Podaj liczbe ponownie");
                    }
                }

                arrLiczb[x] = liczba;
            }

            Console.WriteLine("Największa: " + arrLiczb.Max());
            Console.WriteLine("Na pozycji: " + (arrLiczb.ToList().IndexOf(arrLiczb.Max()) + 1));

            Console.WriteLine("Srednia: " + Liczby.Srednia(arrLiczb));

            Console.ReadLine();
        }
    }
}
