using System;

namespace E_Ticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun telefon = new Urun();
            telefon.Adi = "Xiaomi Mi Note 3";
            telefon.YeniMi = "Yeni Gibi";
            telefon.Fiyati = 1800;

            Urun bilgisayar = new Urun();
            bilgisayar.Adi = "Asus x540uv";
            bilgisayar.YeniMi = "Yeni Gibi";
            bilgisayar.Fiyati = 5000;

            Urun kulaklik = new Urun();
            kulaklik.Adi = "Haylou GT1 Pro";
            kulaklik.YeniMi = "Yeni Gibi";
            kulaklik.Fiyati = 200;

            Urun[] urunler = new Urun[] { telefon, bilgisayar, kulaklik };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].Adi);
            }
            Console.WriteLine(); // Boşluk Bırakmak için.

            int x = 0;
            while (x<urunler.Length)
            {
                Console.WriteLine(urunler[x].Adi);
                x++;
            }
            Console.WriteLine(); // Boşluk Bırakmak için.
            

            foreach (var urunlerim in urunler)
            {
                Console.WriteLine(urunlerim.Adi+" - "+urunlerim.YeniMi+" - "+urunlerim.Fiyati);
            }

            Console.ReadLine();
        }
    }

    
}
