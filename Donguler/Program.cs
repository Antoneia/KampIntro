using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";

            // ARRAY-DİZİ üsttekileri tek tek tanımlamak yerine bunları bir array da tuttum

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı",
                                    "programlamaya başlangıç için temel kurs"," java","python" };



            for (int i =0 ; i < kurslar.Length; i++) //i++ da olur bu şekilde arttırmalıda verirsin
            {
                Console.WriteLine(kurslar [i]);
            }

            Console.WriteLine("for bitti");

            foreach (string xyz in kurslar)   // in kurslar demek kursları dolaş demek
            {                                // burdaki xyz dizileri dolaşmak için verdiğimiz takma 
                Console.WriteLine(xyz);      //bir isim 
            }                                // foreach dizilere uygulanır                     
            




            Console.WriteLine("sayfa sonu - footer ");
            Console.ReadLine();
        }
    }
}
