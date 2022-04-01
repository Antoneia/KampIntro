using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriler = "kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false; // you can say true. your choice

            double dolardun = 7.35;   // elimizdeki veriler bunlar. değişebilir. sabit değil aşağıdaki if else i bu değerlere göre kurguluyoruz.
            double dolarbugun = 7.45; //

            if (dolardun>dolarbugun) // atıyorum dün 7.50 iken bugün 7.00 ise azalmış
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolardun<dolarbugun) //Dünkü dolarımız şu an ki dolarımızdan küçük yani bugünki dolarımız daha yüksek olduğu için dolar artmış demektir.
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }


            if (true)
            {

            }




            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu"); // consol bir simüledir burda sisteme giris yaptığında bu görünecek bunu simüle ediyoruz gerçeğini formda buttonla da yapabiliriz.
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");         
            }
            

                
            Console.ReadLine();

        }
    }
}
