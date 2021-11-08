using System;

namespace Domowe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool niePuste = false;
            string tekst = "";

            Console.WriteLine("POdaj tekst");
            while (!niePuste)
            {
                tekst = Console.ReadLine();
                if (tekst == "")
                {
                    Console.WriteLine("Tekst nie moze byc pusty");
                }
                else
                {
                    niePuste = true;
                }
            }

            // kkkktttrrrrrrrrrr = k4t3r10;
            string testowy = "kkkktttrrrrrrrrrr";
            int countChar = 0;

            char[] charString = testowy.ToCharArray();

            for (int x = 0; x < charString.Length; x++)
            {
                countChar = 1;
                for (int z = 0; z < charString.Length; z++)
                {
                    // tak kurwa wiem c# ze to jest puste, to MA BYC puste.
                    if (charString[x] == charString[z] && charString[x] != '')
                    {
                        countChar++;
                        charString[z] = '0';
                    }
                }
                if (countChar > 1 && charString[x] != '0')
                {
                    Console.WriteLine(charString[x]);
                }
            }
            Console.ReadKey();
        }
    }
}
