using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Liczby
    {
        Liczby()
        {

        }
        static public decimal Srednia(int[] numArr)
        {
            decimal[] dec = new decimal[numArr.Length];
            for(int x = 0; x < numArr.Length; x++)
            {
                dec[x] = Convert.ToDecimal(numArr[x]);
            }
            decimal result = dec.Sum();
            return result / dec.Length;
        }
    }
}
