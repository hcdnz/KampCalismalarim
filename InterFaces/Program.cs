using System;

namespace InterFaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager(); // İnterface'ler kendisini implemente eden class'ın refarance numarasını tutabilir.
            customerManager.Add();

            Console.WriteLine("-----------------------------------");

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            Console.WriteLine("-----------------------------------");

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(employeeManager);
            projectManager.Add(new InternManager());
                                                                      



            Console.ReadLine();
        }
    }

    interface IPersonManager 
        // İnterface'lerde sadece yapılacak işlemin imzası tutulur. İnterface'i impleme eden class'lar içerisinde bulunan işlemleri yapmak zorundadır.
        // Kısaca İnterface'ler aynı operasyonları faklı şekilde yapan sınıflar için kullanılır.
        // İnterface'ler new'lenemez. Çünki içinde herhangi bir operasyon tanımlanmaz.
    {
        void Add();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri ekleme kodları 
            Console.WriteLine("Müşteri Eklendi!");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // PErsonel ekleme kodları
            Console.WriteLine("Personel Eklendi!");
        }
    }
    class InternManager : IPersonManager // Gibi daha sonradan bir sınıf eklediğimizde interface ile çalıştığımız için kod düzeni hata vermez.
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi!");
        }
    }

    class ProjectManager // Tek bir merkezden bütün class'ları yönetebilmek için tanımladık.
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
