using System;

namespace C1_Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEmpty = false;
            string tekst = "";

            do
            {
                tekst = Console.ReadLine();
                if (tekst == "")
                {
                    Console.WriteLine("Tekst nie moze byc pusty");
                }
                else
                {
                    isEmpty = true;
                }
            } while (!isEmpty);

            string[] arrTekst = tekst.Split();
            string result = "";
            for (int i = arrTekst.Length; i-- > 0;)
            {
                result += arrTekst[i] + " ";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
