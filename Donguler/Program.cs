using System;

namespace Donguler // Birbirini tekrar eden işlemler için kullanılır.
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlamak İçin Temel Kurs", "java","Python"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine();

            foreach (var item in kurslar) // Daha basit şekilde dizinin bütün elemanlarını dolaşır.
            {
                Console.WriteLine(item);
            }




            Console.ReadLine();
        }
    }
}
