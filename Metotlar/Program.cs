using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1314;
            urun1.Adi = "Telefon";
            urun1.Fiyati = 2000;
            urun1.Aciklama = "Yeni Gibi";

            Urun urun2 = new Urun();
            urun2.Id = 12121;
            urun2.Adi = "Bilgisayar";
            urun2.Fiyati = 5000;
            urun2.Aciklama = "Sıfır";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (var urunun in urunler)
            {
                Console.WriteLine(urunun.Adi+" - "+urunun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine(); // Boşluk Bırakmak İçin.

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].Adi + " - " + urunler[i].Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("---------------------METOTLAR---------------");

            SepetManager sepetManager = new SepetManager(); // Kullanacağımız class ı tanımladık.
            sepetManager.Ekle(urun1); //Tanımladığımız class daki istediğimiz metodu tanımladığımız herhangi bir yerde çağırabiliriz.
            sepetManager.Ekle(urun2);
            



            Console.ReadLine();
        }
    }
}
