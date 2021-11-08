using System;

namespace Domowe_4
{
    class Program
    {
        // idk why this needs to be 256....
        static int maxCHARS = 256;
        static void calculate(String s, int[] cal)
        {

            for (int i = 0; i < s.Length; i++)
            {
                // i-- i never seen anythiung like it.
                // im not happy with it but it works.....
                cal[s[i]]++;
            }
        }
        static void Main(string[] args)
        {
            bool niePuste = false;
            string tekst = "";

            Console.WriteLine("POdaj tekst");
            do
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
            } while (!niePuste);

            //string testowy = "kkkktttrrrrrrrrrr";
            //int countChar = 0;

            //char[] charString = testowy.ToCharArray();

            int[] cal = new int[maxCHARS];
            calculate(tekst, cal);


            for (int i = 0; i < maxCHARS; i++)
            {

                // if cal is bigger than at least 1 character.
                if (cal[i] > 1)
                {
                    //Console.WriteLine("Character " + (char)i);
                    //Console.WriteLine("Occurrence = " + cal[i] + " times");

                    Console.Write((char)i + "" + cal[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
