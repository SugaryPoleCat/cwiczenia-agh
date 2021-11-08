using System;

namespace Domowe_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // read all lines of the file into an array;
            try
            {
                string[] linje = System.IO.File.ReadAllLines(@"D:\Programming\CS\cwiczenia-agh\Cwiczenia AGH\Cwiczenia 1\Domowe 7");
                Console.WriteLine("OTO BEE MOVIE SCRIPT: ");
                foreach (string linia in linje)
                {
                    Console.WriteLine("\t" + linia);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh nie, oto co sie stalo: " + e);
            }

            Console.ReadKey();
        }
    }
}
