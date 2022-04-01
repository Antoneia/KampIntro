using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; // sayi1 = 30
            sayi2 = 65;
            //sayi1 = 30, sayi2= 65 olur 


            int[] sayilar1 = new int[] { 10,20,30 };
            int[] sayilar2 = new int[] { 100,200,300 };
            sayilar1 = sayilar2; //bu artık sayilar 1 i tutuyor sayilar 2 nin sıfırıncı elemanı 999 a eşitlenmiş yani sayilar bir in sıfırıncı elemanı 999 dur
            sayilar2[0] = 999;
            //sayilar1[0] = 999

        }
    }
}
