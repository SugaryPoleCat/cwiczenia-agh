using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 0;
            bool success = false;
            Console.WriteLine("Give me number: ");
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out myNum);
                if (!success)
                {
                    Console.WriteLine("Try again");
                }
            }
            Console.WriteLine("your number: " + myNum);
            Console.WriteLine("it was: " + success);
            Console.ReadLine();
        }
    }
}
