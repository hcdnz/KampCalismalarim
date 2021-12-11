// See https://aka.ms/new-console-template for more information
using OOP2;

Individual customer1 = new Individual();
customer1.Id = 1;
customer1.FirstName = "Hacı";
customer1.LastName = "Deniz";
customer1.TcNumber = "1234565432";
customer1.CustomerNumber = "2345432";

Coorporate customer2 = new Coorporate();
customer2.Id = 2;
customer2.CustomerNumber = "4242141";
customer2.CompanyName = "Kodlama.io";
customer2.TaxNumber = "2345432";

// Customer Individual ve Coorporate'nin referance'lerini tutabiliyor.
Customer customer3 = new Individual();
Customer customer4 = new Coorporate();


CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(customer3);
customerManager.Add(customer4);










Console.ReadLine();
