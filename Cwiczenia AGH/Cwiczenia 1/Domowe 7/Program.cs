using System;
using System.IO;

namespace Domowe_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // read all lines of the file into an array;
            try
            {
                // Get current directory/.
                string CD = Directory.GetCurrentDirectory();

                // Path works just like in Node.
                // This is basically path.join();.
                // getFullPath gets full path D:\something\exdeee
                // combione combines 2 paths, into one full path. 
                // because in C# you cant just do ..\..\..\ when making your own path, you need to do path.combine.
                CD = Path.GetFullPath(Path.Combine(CD, @"..\..\..\tekst.txt"));
                string[] linje = System.IO.File.ReadAllLines(CD);

                Console.WriteLine("OTO BEE MOVIE SCRIPT: ");
                // write out each line.
                // for reach LINIA in LINJE.
                foreach (string linia in linje)
                {
                    Console.WriteLine("\t" + linia);
                }
                Console.WriteLine("KONIEC");
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh nie, oto co sie stalo: " + e);
            }

            Console.ReadKey();
        }
    }
}
