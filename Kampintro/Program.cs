using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis butonu");
            }
            else
            {
                Console.WriteLine("Esittir butonu");
                         
            }

            if (sistemeGirisYapmisMi == true) 
            {
                Console.WriteLine("Kullanici ayarlari butonu");

            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            

        }
    }
}
