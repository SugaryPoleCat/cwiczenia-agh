using System;

namespace Domowe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Data twoja urodzenia (yyyyMMdd): ");

            string[] formaty = { "yyyyMMdd", "HHmmss" };
            DateTime data = new DateTime();
            bool toData = false;
            while (!toData)
            {
                toData = DateTime.TryParseExact(Console.ReadLine(), formaty, null, System.Globalization.DateTimeStyles.AllowWhiteSpaces | System.Globalization.DateTimeStyles.AdjustToUniversal, out data);
                if (!toData)
                {
                    Console.WriteLine("Zle wprowadzona data.");
                }
            }

            DateTime teraz = DateTime.Now;
            //if()
            // YES C#!! YES I KNOW ITS EMPTY!!!! IT CAN BE FUCKING EMPTY!!!!!
            double result = (teraz.Date - data.Date).TotalDays;
            Console.WriteLine("Minelo: " + result + " dni od day urodzin.");

            Console.ReadKey();
        }
    }
}
