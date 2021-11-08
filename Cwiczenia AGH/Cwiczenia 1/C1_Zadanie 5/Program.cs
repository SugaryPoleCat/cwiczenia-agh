using System;

namespace C1_Zadanie_5
{
    class Program
    {
        double Odwrotnosc(double x)
        {
            string toBack = Convert.ToString(x);
            string[] backwards = toBack.Split();
            string[] isBack = new string[backwards.Length];

            for(int i = backwards.Length; i-->0;)
            {
                ///isBack[]
            }

            double y = 0;
            return y;
        }
        static void Main(string[] args)
        {
            bool isOk = false;
            double real = 0;
            Console.Write("dawaj numer double: ");
            do
            {
                try
                {
                    isOk = double.TryParse(Console.ReadLine(), out real);
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!isOk);



            Console.WriteLine($"oto twoja odwrotna liczba: ");
            Console.ReadKey();
        }
    }
}
