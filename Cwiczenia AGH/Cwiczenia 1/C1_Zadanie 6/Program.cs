using System;

namespace C1_Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEmpty = false;
            string tekst = "";
            Console.WriteLine("Podaj tekst: ");
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

            // method 1
            string[] arrTekst = tekst.Split();
            string result = "";
            for (int i = arrTekst.Length; i-- > 0;)
            {
                result += arrTekst[i] + " ";
            }
            Console.WriteLine("Metoda 1\n" + result);

            // method 2.
            result = "";
            Array.Reverse(arrTekst, 0, arrTekst.Length);
            foreach(string txt in arrTekst)
            {
                result += txt + " ";
            }
            Console.WriteLine("Metoda 2\n" + result);
            Console.ReadKey();
        }
    }
}
