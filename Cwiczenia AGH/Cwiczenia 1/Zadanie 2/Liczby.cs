using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Liczby
    {
        /// <summary>
        /// konstruktor.Nie musi byc uzywany. Jest jako publik, zeby byl dostepny w innych klasach.
        /// </summary>
        public Liczby()
        {

        }
        /// <summary>
        /// To przeliczy srednia naszych liczb. Jest to metoda STATIC, wiec nie trzeba jej inicjalizowac przed uzyciem, jak 
        /// w przypadku konstruktora. Wystarczy: Liczby.Srednia(arrayCyfr)
        /// </summary>
        /// <param name="numArr">Array liczb jako int</param>
        /// <returns>resultat w decimal.</returns>
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
