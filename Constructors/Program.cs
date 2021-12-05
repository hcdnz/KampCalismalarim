using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Hacı", LastName = "Deniz", City = "Kırşehir" };
            // DEĞERLERİMİZİ BU ŞEKİLDE TANIMLADIĞIMIZDA DEFAULT CONSTRUCTOR ÇALIŞIR.
            Console.WriteLine(customer1.LastName);

            Console.WriteLine("-------------------");
            
            Customer customer2 = new Customer(1, "Büşra", "Deniz", "Kırşehir");
            // DEĞERLERİ BU ŞEKİLDE TANIMLADIĞIMIZDA İSE PARAMETRE VERDİĞİMİZ CONSTRUCTOR ÇALIŞIR.
            Console.WriteLine(customer2.FirstName);


            
            
            
            
            Console.ReadLine();
        }
    }

    class Customer
    {
        public Customer() // Default Constructor // ctor + TabTab ile otomatik bir constuctor tanımlayabiliriz. 
        {

        }
        public Customer(int id,string firstName,string lastName,string city) 
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
