using System;

namespace CW_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbe n");
            //if (int.TryParse(Console.ReadLine(), out int n))

            // Figura(n);

            //string x = Console.ReadLine();
            //int n = int.Parse(x);

            //if(int.TryParse(Console.ReadLine(), out int n)) //inny parse ktory obsluguje wyjatki i nie crashuje programu jak sie nie uda


        }

        static void Figura(int n)
        {


            if (n <= 2 || n % 2 != 1)
            {
                Console.WriteLine("blad bo podales liczbe parzysta");
            }
            else
            {

                for (int i = 0; i < n; ++i)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                for (int i = 1; i < n - 1; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        if (j == 0 || j == i || j == n - i - 1 || j == n - 1)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }


                    }

                    Console.WriteLine();


                }
                for (int i = 0; i < n; ++i)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void Liczby()
        {
            Console.WriteLine("Podaj liczb n:");
            //while ()
        }




    }
}
