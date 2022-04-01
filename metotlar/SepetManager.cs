using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class SepetManager 
    {
        //metot oluşturma ----------Urun ti
        public void Ekle(Urun urun)  //senin neyi eklemek istediğini metota vermen lazım buna parametre diyoruz
        {
            Console.WriteLine("sepete eklendi : "  +  urun.adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokdedi)  // Bir class ın içinde birden fazla metot olabilir
        {
            Console.WriteLine("tebrikler sepete eklendi" + urunAdi);
        }



      }
}
