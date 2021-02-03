using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Pogramlamaya baslangic icin temel kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi", "Pogramlamaya baslangic icin temel kurs", "Java","python","c++" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
