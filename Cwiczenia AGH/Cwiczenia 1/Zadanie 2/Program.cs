using System;
using System.Linq;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile = 0;
            bool toLiczba = false;
            Console.WriteLine("Podaj ile liczb chcesz: ");
            while (!toLiczba)
            {
                toLiczba = int.TryParse(Console.ReadLine(), out ile);
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
            Liczby chuj = new Liczby();

            Console.ReadLine();
        }
    }
}
