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
            Console.WriteLine("Ile liczb: ");
            while (!toLiczba)
            {
                toLiczba = int.TryParse(Console.ReadLine(), out ile);
                if (!toLiczba)
                {
                    Console.WriteLine("Podaj ile liczb w cyfrach. Liczba musi byc calkowita.");
                }

            }
            Console.WriteLine("Teraz podaj " + ile + " liczb ktore zssumujemy i podamy ktora jest najwieksza.");

           int[] numArr = new int[ile];
            for(int x=0; x<ile; x++)
            {
                int liczba = 0;
                bool toLiczba2 = false;
                while (!toLiczba2)
                {
                    Console.WriteLine("Podaj liczbe na pozycje " + x + ": ");
                    toLiczba2 = Int32.TryParse(Console.ReadLine(), out liczba);
                    if (!toLiczba2)
                    {
                        Console.WriteLine("Podaj liczbe w cyfrach. Liczba musi byc calkowita.");
                    }

                }
                numArr[x] = Convert.ToInt32(liczba);
            }
            Liczby liczby = new Liczby(numArr);
            liczby.countStuff();
            Console.ReadLine();
        }
    }
}
