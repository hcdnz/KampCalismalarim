using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs(); // paramatresi Kurs olan kurs1 adında bir yeni değer tutucu oluşturduk
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Hacı";
            kurs1.IzlenmeOrani = 10;
            
            Kurs kurs2 = new Kurs(); //paramatresi Kurs olan kurs2 adında bir yeni değer tutucu oluşturduk
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Büşra";
            kurs2.IzlenmeOrani = 20;
            
            Kurs kurs3 = new Kurs(); //paramatresi Kurs olan kurs3 adında bir yeni değer tutucu oluşturduk
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Akkoç";
            kurs3.IzlenmeOrani = 30;

            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmeni);
            Console.WriteLine(); // Boşluk bırakmak için.

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3}; // Parametresi Kurs olan kurslar isminde liste oluşturup eleman olarak değer tutucuları ekledik.

            foreach (var kurs in kurslar) 
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);
            }
            Console.WriteLine();

            int yas = 19;

            string sonuc = yas > 20 ? "A" : yas == 20 ? "B" : "C"; // Ternary Operatörü.
            Console.WriteLine(sonuc);
            Console.WriteLine();


            Console.ReadLine();
        }
    }

    class Kurs // int, string gibi değer tutacak Kurs isminde bir sınıf tanımladık.
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
