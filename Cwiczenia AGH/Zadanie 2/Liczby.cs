using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Liczby
    {
        int[] numArr;
        public Liczby(int[] arrNUm)
        {
            numArr = arrNUm;
        }        
        public void countStuff()
        {
            Console.WriteLine("Najwieksza liczba: " + numArr.Max());
            Console.WriteLine("Suma Liczb: " + numArr.Sum());
        }
    }
}
