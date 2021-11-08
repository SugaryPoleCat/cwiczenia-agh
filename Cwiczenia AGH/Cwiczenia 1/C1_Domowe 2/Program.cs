using System;

namespace Domowe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe: ");
            bool toLiczba = false;
            uint liczba = 0;

            while (!toLiczba)
            {
                toLiczba = uint.TryParse(Console.ReadLine(), out liczba);
                if (!toLiczba)
                {
                    Console.WriteLine("Sprobuj ponownie");
                }
            }

            uint ilosc3 = 0;
            try
            {
                uint rownanie = liczba % 3;
                // nie wiem czy to o to chodzi.
                if (rownanie == 0)
                {
                    Console.WriteLine("Liczbe mozna dzielic przez 3.");
                }
                else
                {
                    Console.WriteLine("nie, liczbny nie mozna dizlic przez 3");
                }
                // chyba ze o to im chodzi?
                string liczbaString = Convert.ToString(liczba);
                for (int x = 0; x < liczbaString.Length; x++)
                {
                    Console.WriteLine($"pozycja {x}: {liczbaString[x]}");
                    // czemu to krwa double
                    double check = Char.GetNumericValue(liczbaString[x]);
                    if (check == 3)
                    {
                        Console.WriteLine("znaleziono");
                        ilosc3++;
                    }
                }
            }
            // try/catch mozna miec wiele catch.
            // kazdy catch moze odpowiadac za inny exception
            // czyli np, jak uzytwkonik wpisze tekst zamiast cyfry, inny error.
            // wpiusze decimal na int, inny eror, itp.
            // na koncu MOZNA ale nie MUSI sie, dac finally()
            // finally zostanie wykonany niewazne czy byl exception czy nie.
            catch (ArithmeticException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            if (ilosc3 < 1)
            {
                Console.WriteLine("nie, nie znaleziono 3 w liczbnie.");
            }
            else
            {
                Console.WriteLine($"Znaleziono {ilosc3} troijek.");
            }
            Console.ReadLine();
        }
    }
}
