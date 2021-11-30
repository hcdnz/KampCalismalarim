using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir ATM uygulaması tanımlayıp kullanıcıdan değer alıp aldığımız değere göre işlemler yapalım.
            // 1- Bakiye Öğrenme
            // 2- Para Çek
            // 3- Para Yatır
            // 4- Çıkış Yap
            // 1-2-3-4 dışında bir değer girilmişse hata versin.

            int bakiye = 700;

            Console.WriteLine("ATM'ye Hoşgeldiniz..");
            Console.WriteLine("Lütfen Bir İşlem Seçiniz");
            Console.WriteLine("1- Bakiye Görüntüle");
            Console.WriteLine("2- Para Çek");
            Console.WriteLine("3- Para Yatır");
            Console.WriteLine("4- Çıkış Yap");

            string secim = Console.ReadLine(); // Kullanıcıdan değer istedik.

            switch (secim) // Kullanıcının girdiği değere göre işlemler tanımlayacağız.
            {
                case "1": 
                    Console.WriteLine("Bakiyeniz :"+bakiye);
                    break;

                case "2":
                    Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz");
                    int cekilecekTutar = Convert.ToInt32(Console.ReadLine()); // cekilecekTutar'ı kullanınıcının girdiği değer olaral tanımladık.
                                                                              // ve matematiksel işlem yapacağımız için dönüştürdük.

                    if (cekilecekTutar>bakiye)
                    {
                        Console.WriteLine("Bakiye Yetersiz!");
                    }
                    else
                    {
                        Console.WriteLine("Kalan Bakiyeniz : " + (bakiye - cekilecekTutar));
                    }
                    break;

                case "3":
                    Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz..");

                    int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yeni Bakiyeniz : " + (bakiye + yatirilacakTutar));
                    break;

                case "4":
                    Console.WriteLine("Hesabınızdan Çıkış Yapılıyor, İyi Günler!");
                    break;

                default: 
                    Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz");
                    break;

                    Console.ReadLine();



            }










        }
    }
}
