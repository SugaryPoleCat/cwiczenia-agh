using System;

namespace CW_1
{
    class MainClass2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe n");

            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
            {
                Console.WriteLine("Bledne dane");
                return;
            }

            //int s = 0, amax = 0, amin = 0;
            for (int i = 0; i < n; ++i)
            {
                Console.Write($"Podaj liczbę [{i + 1}]: ");
                //if (int)
            }
        }
    }
}
