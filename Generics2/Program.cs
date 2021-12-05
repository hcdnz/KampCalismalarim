using System;
using System.Collections.Generic;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Kırşehir");
            sehirler.Add("Kırşehir");
            sehirler.Add("Kırşehir");
            Console.WriteLine(sehirler.Count);

            Console.WriteLine("___________________________________________________________");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Kırşehir");
            sehirler2.Add("Kırşehir");
            sehirler2.Add("Kırşehir");
            sehirler2.Add("Kırşehir");
            Console.WriteLine(sehirler2.Count);
            

            Console.ReadLine();
        }
    }

    class MyList <T> // İstediğimiz type de bir list tanımlamak için öylesine seçtiğimiz bir harf atadık. GENERİC CLASS
    {
        T[] _array;
        T[] _tempArray; // Geçici array. (Yeni eleman eklemek için newlendiğinde eski listemiz kaybolmasın diye tanımlayık.
        public MyList() // MyList çalıştığında arka planda sıfır elemanlı bir dizi oluşturduk.
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _array = new T[_array.Length + 1]; 
            _tempArray = _array; // _array'in referancesini tutturuyoruz.
            
            for (int i = 0; i < _tempArray.Length; i++) // Geçici listemizden elemanları aktarmak için tanımladık.
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;   
        }

        public int Count // Count'u çalıştırabilmek için bir metot tanımladık.
        {
            get { return _array.Length; }
           
        }

    }
    
}
