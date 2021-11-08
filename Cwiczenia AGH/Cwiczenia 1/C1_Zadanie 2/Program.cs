using System;
using System.Linq;

namespace Zadanie_2
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numArr">Array liczb jako int</param>
        /// <returns>resultat w decimal.</returns>
        static decimal Srednia(int[] numArr)
        {
            // stworz nowa tabele, tym razem decimal, o dlugosci tej samej co orginalny.
            decimal[] dec = new decimal[numArr.Length];

            // przeloopuj przez nasz nowy array, tak jak robilismy to w Main.
            for (int x = 0; x < numArr.Length; x++)
            {
                // zapisz na TEJ samiej pozycji w decimal, ta samo liczbe z naszego array
                // ktory podalismy tej funkcji.
                dec[x] = Convert.ToDecimal(numArr[x]);
            }

            // .Sum() jest standardowa funkcja Array, ale tylko jezeli masz
            // using System.Linq;.
            decimal result = dec.Sum();

            // ale mozna zrobic to samo takim sposobem, jak nie masz dostepu do linq.
            decimal suma = 0;
            for (int x = 0; x < dec.Length; x++)
            {
                // dodaj do sumy, nasze liczby po kolei, od pozycji [0],
                // az do konca naszego array dec[].
                // dlatego wpisujemy x < dec.Length.
                // bo length jest podawany w CZYTELNY sposob dla uzytkownika,
                // czyli jak masz 1 wartosc w array,
                // to array.length wyswietli 1.
                // a array zaczyna ise od 0.
                // dlatego zawsze jak loopujesz przez array, zaczyna sie
                // for loop od 0.
                suma += dec[x];
            }

            // wzroc nasz rezultat, dzielony przez dlugosc array, czyli po prostu przez ile liczb podalismy.
            return result / dec.Length;
        }
        static void Main(string[] args)
        {
            // Ile liczb uzywtkonik chce
            int ile = 0;

            // to zmieni sie jezeli uzytkownik wpisze liczbe. Inicjalnie: false.
            bool toLiczba = false;
            Console.WriteLine("Podaj ile liczb chcesz: ");
            while (!toLiczba)
            {
                toLiczba = int.TryParse(Console.ReadLine(), out ile);   // proboj wkleic INPUT z CONSOLE jako int.

                // Jezeli sie uda, ustaw ILE, czyli to out.
                // jezeli nie udalo sie, to "t
                if (!toLiczba)
                {
                    Console.WriteLine("Podaj liczbe ponownie");
                }
            }

            // W C#, c# musi wiedziec jak wielki jest nasz array zanim go uzyjemy.
            // dlatego wklejamy ile, w nawiasy.
            int[] arrLiczb = new int[ile];

            // inicjalizacja WIELU integerow naraz.
            int max = 0, suma = 0;

            // for loop.
            // chcemy przeloopowac przez caly array. nie musimy przez dlugosc array,
            // mozna dac x < ile, i bedzie to samo.
            // x++ dodaje 1 do x, za kazdym loopem.
            for (int x = 0; x < arrLiczb.Length; x++)
            {
                // nadpisz poprzedni bool, zeby nie robic nowego.
                toLiczba = false;
                int liczba = 0;

                // array zaczyna sie od 0.
                // uzytkownik nie wie o tym wiec dodajemy +1 do pozycji x.
                // mozna tez dac w for (x = 1) ale wtedy zaczniemy na pozycji 1 w array.
                Console.WriteLine("Podaj liczbe na pozycje: " + (x + 1) + "/" + ile);
                // poki BOOL toLiczba jest FALSE, wykonaj dzialanie mieddzy {}
                while (!toLiczba)
                {
                    // sprobuj wkleic z Consoli input  uzytkownika.
                    // TryParse wzraca sie jako Bool, czyli true albo false.
                    // out w nawiasach mowi o tym, ze-- jezeli bool jest true,
                    // czyli ze sie da wkleic nasz input jako inteeger
                    // to wpisz nasz imput, do integera LICZBA.
                    toLiczba = int.TryParse(Console.ReadLine(), out liczba);
                    // sprawdz czy toLiczba jest false, jezeli tak, wyswietl komunikat.
                    if (!toLiczba)
                    {
                        Console.WriteLine("Podaj liczbe ponownie");
                    }
                }

                // dodaj liczbe to array, w miejsu X.
                arrLiczb[x] = liczba;

                // += to skrot od: suma = suma + liczba;
                // tak samo jest -=, *= i /=.
                suma += liczba;
                // Sprawdz czy aktualna LICZBA jest WIEKSZA od ostatnio wpisanej MAKSYMALNEJ liczby.
                if (liczba > max)
                {
                    // jezeli tak, nadpisz ja nowa liczba.
                    // efektywnie zapisujac nowa maksymalna liczbe.
                    max = liczba;
                }
            }
            Console.WriteLine("Największa: " + arrLiczb.Max());

            // wyswietl z array na ktorej pozycji jest nasza maksymaln liczba.
            Console.WriteLine("Na pozycji: " + (arrLiczb.ToList().IndexOf(arrLiczb.Max()) + 1));

            Console.WriteLine("Srednia: " + (Srednia(arrLiczb)).ToString("N2"));

            Console.WriteLine("BEZ UZYCIA ARRAY");
            // znak $ przed ", oznacza ze do tekstu mozemy doczepiac WARTOSCI
            // miedzy { } znakami.
            // robimy rownanie pomiedzy znakami ( ), bo najpierw chcemy je WYKONAC
            // a potem to rownanie, zapisac jako String, z 2 decimalami.
            // ToString("N2") oznacza ile wartosci po przecinku wypisujemy.
            Console.WriteLine($"Max: {max}\nSrednia: {(suma / ile).ToString("N2")}");

            // Readline: dopoki nie nacisniesz enter, mozesz pisac co chcesz i nic sie nie dzieje.
            // ReadKey: po nacisnieciu BYLE JAKIEGO klawisza, nastepuje nastepne dzialanie.
            // w tym przypadku, bo jest to ostatnia komenda, wyjdz z programu.
            Console.ReadKey();
        }
    }
}
