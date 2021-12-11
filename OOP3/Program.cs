// See https://aka.ms/new-console-template for more information
using OOP3;

ICreditManager needCreditManager = new NeedCreditManager(); //Interface inherit edildiği class'ın referance numarasını tutabilir.
ICreditManager vehicleCreditManager = new VehicleCreditManager();
ICreditManager housingCreditManager = new HousingCreditManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService(); //Interface inherit edildiği class'ın referance numarasını tutabilir.
ILoggerService fileLoggerService = new FileLoggerService();

RecourseManager recourseManager = new RecourseManager();
recourseManager.RecourseMake(vehicleCreditManager, databaseLoggerService);
Console.WriteLine("------------------------------------------------------");
recourseManager.RecourseMake(vehicleCreditManager, fileLoggerService); 

List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager,housingCreditManager }; // Müşterimiz için seçilen kredi türleri
//recourseManager.CreditOnBilgilendirmesiYap(credits); // Seçilen kredi türlerine göre işlemimizi yaptırdık.



Console.ReadLine();
