using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoeri";
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine();

            int ogrenciSayisi = 10;
            double faizOrani = 10.4;

            Console.WriteLine();
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonunu göster");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            Console.WriteLine();
            bool sistemeGirisYapmisMi = false;
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            Console.ReadLine();
        }
    }
}
