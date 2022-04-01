using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "ENGİN";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Bilal Keserci";
            kurs2.IzlenmeOranı = 65;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "Vefa Keserci";
            kurs3.IzlenmeOranı = 31;

            //Console.WriteLine(kurs1.KursAdi +  " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs bok in kurslar) // burdaki kurs veri tipi biz aslında class larda kendi veri tipimizi
            {

                Console.WriteLine(bok.KursAdi + " :  " + bok.Egitmen);                    // yaratıyoruz
            }
            Console.ReadLine();


        }

        class Kurs
        {
            public string KursAdi  { get; set; }
            public string Egitmen  { get; set; }
            public int IzlenmeOranı { get; set; }
        }


    }
}
