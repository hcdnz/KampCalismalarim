using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine("SAYI 1 = " + sayi1);
            // İNT DEĞER TİP OLDUĞU İÇİN CEVABIMIZ 30 DUR //

            Console.WriteLine("------------------------------------");

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine("SAYILAR 1'IN ILK ELEMANI = " + sayilar1[0]);
            // LİSTLER REFERANS TİPLER OLDUĞU İÇİN CEVAP 999 OLUR // 







            Console.ReadLine();
        }
    }
}
