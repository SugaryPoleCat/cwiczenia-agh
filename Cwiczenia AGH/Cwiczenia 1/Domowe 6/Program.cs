using System;

namespace Domowe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2021, 12, 31, 23, 59, 59);
            DateTime teraz = DateTime.Now;

            double result = (data.Date - teraz.Date).TotalDays;
            Console.WriteLine("Pozosalo: " + result + " dni do konca roku.");

            Console.ReadKey();
        }
    }
}
