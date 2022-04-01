using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
        class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); //class oluşturma
            urun1.adi = "elma";
            urun1.fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.adi = "karpuz";
            urun2.fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };//ürün ün array ini oluşturduk
            foreach (var urun in urunler) // urun bizim kendi taktığımız ad, urunler dizisindeki tüm ürünleri dolaşıyor şimdi bunula istediğini yapabilirsin
            {
                Console.WriteLine(urun.adi);
                Console.WriteLine(urun.fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------------------------");
                
            }
            Console.WriteLine("------------Metotlar-----------------");
            // class oluştur önce
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle2("armut", "yeşil armut", 12, 14);
            
            Console.ReadKey();
        }
    }
}
