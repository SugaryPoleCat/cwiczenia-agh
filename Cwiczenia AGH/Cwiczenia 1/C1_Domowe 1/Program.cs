using System;

namespace Domowe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbe Decimal: ");
            bool toLiczba = false;
            decimal oJa = 0;
            do
            {
                toLiczba = decimal.TryParse(Console.ReadLine(), out oJa);
                if (!toLiczba)
                {
                    Console.WriteLine("Proboj ponownie");
                }
            } while (!toLiczba);

            Console.Write("Podaj liczbe rzeczywsta: ");
            toLiczba = false;
            int rzeczywista = 0;

            do
            {
                toLiczba = int.TryParse(Console.ReadLine(), out rzeczywista);
                if (!toLiczba)
                {
                    Console.WriteLine("Proboj ponownie");
                }
            } while (!toLiczba);

            // $ pozwala wpisywac wartosci odrazu w teksts
            Console.WriteLine($"+: {oJa + rzeczywista}");
            Console.WriteLine($"Decimal - rzeczywista: {oJa - rzeczywista}");
            Console.WriteLine($"Rzeczywista - decimal: {rzeczywista - oJa}");
            Console.WriteLine($"*: {Math.Round(oJa * rzeczywista, 2)}");

            // tostring("n2") to ile decimal points. 2 to ilosc decimal points.
            // robimy to w nawiasie, bo najpierw wykonaj rownanie, a potem zrob to jako string
            // z 2 decimals. Mozna tez uzyc math.round, jak w rownaniu *.
            Console.WriteLine($"Decimal / rzeczywista: {(oJa / rzeczywista).ToString("N2")}");
            Console.WriteLine($"Rzeczywista / decimal: {(rzeczywista / oJa).ToString("N2")}");
            Console.WriteLine($"Decimal / rzeczywista: {(oJa / rzeczywista).ToString("N2")}");
            Console.WriteLine($"Rzeczywista / decimal: {(rzeczywista / oJa).ToString("N2")}");

            Console.ReadLine();
        }
    }
}
