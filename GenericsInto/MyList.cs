//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace GenericsInto
//{
//    class MyList<T> // T Yerine kullanıcı hangi tip girerse o tip ile  çalışmasını söyler.
//    {
//        T[] items; // Add sınıfının çalışması için bir array tanımladık. Array'in newlenme zorunluluğu olduğu için Constructor tanımladık.
//        public MyList() //Sınıf newlendiğinde otomatik olarak bir dizi tanımlansın diye oluşturduk.
//                        //Constructor class newlendiğinde diğer sınıflardan önce çalışır. (ctor + tabtab)
//        {
//            items = new T[0];
//        }
//        public void Add(T item) // item = eleman
//        {
//            T[] tempArray = items; // Yeni eleman eklenmesi için new yapıldığında eski veriler gitmesin diye bir geçiçi dizi oluşturduk.
//            items = new T[items.Length + 1]; // Ekleme işlemi yapabilmesi için tanımlı dizinin eleman sayısını 1 artırmasını söyledik.   

//            for (int i = 0; i < tempArray.Length; i++) // TempArray de sakladığımız eski elemanları yeni dizimize tekrardan almak için tanımladık.
//            {
//                items[i] = tempArray[i];
//            }
//            items[items.Length] = item; // Add komutu ile gelen elemanı listenin sonuna ekledik.
//        }   

//        public T[] Items // Dizi elemanlarını yazdırabilmek için.
//        {
//            get { return items; }
//        }

//        public int Length // Dizi eleman sayısını yazdırabilmek için.
//        {
//            get { return items.Length; }
//        }

//    }
//}
