using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dictionary sınıfı sizin belirleyeceğiniz değişkenlere uygun olarak değerler saklayabilir. 
             * Değişkeni belirlemek zorunludur. (int,string..)
            */
            Dictionary<string, int> Adyas = new Dictionary<string, int>(); // Bu şekilde tanımlanır.

            Adyas.Add("Hacı", 26); // Gibi eleman eklenebilir.
            Adyas.Add("Büşra", 24);
            Adyas.Add("Akkoç", 28);

            foreach (var item in Adyas) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------");

            var elemansayisi = Adyas.Count(); // Eleman sayısını yazdırabiliriz.
            Console.WriteLine("Eleman Sayısı : " + elemansayisi);

            Console.WriteLine("---------------------");

            Adyas.Remove("Akkoç");

            foreach (var item in Adyas)
            {
                Console.WriteLine(item);
            }
            




            Console.ReadLine();
        }
    }
}
