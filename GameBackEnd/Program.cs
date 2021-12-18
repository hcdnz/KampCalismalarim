// See https://aka.ms/new-console-template for more information
using GameBackEnd.Concrete;
using GameBackEnd.Entities;

Gamer Hacı = new Gamer()
{
    DateOfBirth = new DateTime(1995, 06, 18),
    FirstName = "Hacı",
    LastName = "Deniz",
    IdentityNumber = 12345
};

Gamer Büşra = new Gamer()
{
    DateOfBirth = new DateTime(1998, 07, 15),
    FirstName = "Büşra",
    LastName = "Deniz",
    IdentityNumber = 12345
};

GamerManager gamerManager = new GamerManager(new UserValidationManager());

gamerManager.Add(Hacı);
gamerManager.Add(Büşra);

OrderManager orderManager = new OrderManager();

orderManager.Order(Büşra, new NewCampaignManager());
orderManager.Order(Hacı, new UpdateCampaignManager());
orderManager.Order(Büşra, new RemoveCampaignManager());

Console.ReadLine();

