using System;

namespace GenericsInto
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<string> isimler = new MyList<string>(); // string değerini biz seçtik, int ya da başka bir değer de verebilirdik.
            //isimler.Add("Hacı");
            //isimler.Add("Büşra");
            //Console.WriteLine(isimler.Length);
            //foreach (var item in isimler.Items)
            //{
            //    Console.WriteLine(item);
            //}

            string[] nasiflar = new string[] { "Nasuh", "Şaziye" };
            Console.WriteLine(nasiflar[0]);


            Console.ReadLine();
            
        }
    }
}
