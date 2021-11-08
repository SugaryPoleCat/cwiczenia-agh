using System;

namespace C1_Zadanie_5
{
    class Program
    {
        static double Odwrotnosc(double x)
        {
            string toBack = Convert.ToString(x);
            char[] backwards = toBack.ToCharArray();
            Array.Reverse(backwards, 0, backwards.Length);
            //double[] isBack = new double[backwards.Length];
            string isBack = "";
            for(int i = 0; i < backwards.Length; i++)
            {
                isBack += backwards[i];
            }

            // it reverses here, but then-- 
            double result = Convert.ToDouble(isBack);

            // -- result is the same as input?
            return result < 0 ? -Math.Abs(x) : result;
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
            double result = Odwrotnosc(real);
            Console.WriteLine($"oto twoja odwrotna liczba: {result}");
            Console.ReadKey();
        }
    }
}
