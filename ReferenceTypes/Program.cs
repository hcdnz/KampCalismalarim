using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // REFERANCE TYPE'LER : STRİNG, ARRAYS,CLASS,INTERFACE.. 
            // DEGER TYPE'LER : İNT, DECİMEAL, FLOAT, BOOLEAN, VALUE TYPES ( SAYISAL DEĞİŞKENLER )

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("Sayı 1'in değer: "+ sayi1);
            // Integer bir değer tiptir. Değer tiplerde eşitleme yapıldığında o anki değeri eşitlenir.
            // Eşitlenen değişkenin değeri daha sonradan değiştirilirse bile bu sonucumuzu etkilemez. Çünkü referance tip değil.
            Console.WriteLine("-------------------------------");

            int[] sayilar1 = new int[] { 1, 2, 3};
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2; // Sayilar 1'in referance numarasındaki veriler otomatik olarak sistem tarafından temizlenir.
            sayilar2[0] = 1000;

            Console.WriteLine("Sayilar 1 dizisinin ilk elemanı: "+ sayilar1[0]);
            // Diziler bir referance tiptir. Referance tiplerde eşitleme yapıldığında referance numarası eşitlenir.
            // Eşitlenen değişkenin değerinde yapılacak değişiklikler o referance numarasını taşıyan bütün değişkenleri etkiler.
            Console.WriteLine("-------------------------------");


            Person person1 = new Person();
            Person person2 = new Person();

            person2.FirstName = "Hacı";
            person1 = person2;

            Console.WriteLine("Person 1'in İsmi : " + person1.FirstName);
            Console.WriteLine("//////////////////////////////");

            person2.FirstName = "Büşra";
            Console.WriteLine("Person 1'in İsmi : " + person1.FirstName);
            Console.WriteLine("-------------------------------");



            Customer customer = new Customer();
            customer.FirstName = "Akkoç";
            customer.CreditCardNumber = 12345432;
           
            Employee employee = new Employee();
            employee.FirstName = "Furkan";

            Person person3 = customer; 
            Console.WriteLine("Person 3'ün Adı : " + person3.FirstName); // Customer ve Employee aynı zamanda bir Person olduğu için bu atamayı yapabildik.
                                                                         // Person üzerinden bu işlemi yaptığımız için Customer'a özel tanımladığımız değeri göremeyiz.(CreditCardNumber)
                                                                         // Eğer Customer değerlerinden birini görmek istersen de şu şekilde yazmamız gerekir.
            Console.WriteLine(((Customer)person3).CreditCardNumber );
            Console.WriteLine("---------------------------------");

            PersonManager personManager = new PersonManager();
            personManager.Add(employee); // PersonManager'imize Person parametresini verdiğimiz için employee kullanabiliriz.


            Console.ReadLine(); 
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person //Base sınıf
    {
        public int CreditCardNumber { get; set; }
    }

    class Employee : Person //Base sınıf (Employe = çalışan)
    {
        public int EmloyeeNumber { get; set; } 
    }

    class PersonManager
    {
     public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
