using System;

namespace Domowe_3
{
    class Program
    {
        // ten kod po prostu sciagnalem, bo kurwa --- chyba polskiego nie znam.
        // nie rozumiem co to jest pierwiastek cyrowy, ale chodzi cos o 
        // Number persistance, sum of digits in number.

        /// <summary>
        /// Sumowanie cyfr.
        /// </summary>
        /// <param name="a">jaka liczbe sumowac.</param>
        /// <returns>ile razy trzeba robic a%10 zeby uzyskac a >= 0.</returns>
        static int sumDigits(int a)
        {
            // init
            int w = 0;
            do
            {
                // dodaj pozostalosc z a.
                // czy da sie dzielic przez 10.
                w += a % 10;
                // jezeli nasz wzrot jest wiekszy niz 0, probuj ponownie.
            } while ((a /= 10) > 0);
            return w;
        }

        static int countPersistance(int a)
        {
            // if mozna tak pisac, JEZELI, kod co ma byc miedzy { },
            // jest tylko 1 linijka.
            // czyli if(cos == x){ return cos; }
            // mozna pisac if(cos == x) return cos;
            if (a < 10)
                return 0;
            // oto nasza wzrotka, ile razy trzeba jechac przez cyfre a,
            // zeby w koncu wzracala 0 przy % ja przez 10.
            int w = sumDigits(a);

            // ? 0 : cos;
            // to jest po prostu true/false.
            // JEZELI, argument po LEWEJ od ?, jest TRUE, wzroc 0 ALBO (: to oznacza albo)
            // albo to po prawej od :.
            return 1 + ((w < 10) ? 0 : countPersistance(w));
        }

        /// <summary>
        /// to jest szukanie pierwiastka.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int countDigitalRoot(int a)
        {
            // sumuj a W TEJ funkcji, dopoki a, jest wieksze lub rowne 10.
            do
            {
                a = sumDigits(a);
            } while (a >= 10);
            return a;
        }

        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbe do sprawdzenia\na = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("trwałość: {0}", countPersistance(a));
            Console.WriteLine("pierwiastek cyfrowy: {0}", countDigitalRoot(a));
            Console.ReadKey();
        }
    }
}
