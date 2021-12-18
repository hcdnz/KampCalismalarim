using GameBackEnd.Abstract;
using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEnd.Concrete
{
     class GamerManager:IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }


        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Oyuncu Eklendi!");
            }
            else

            { Console.WriteLine("Oyuncu Doğrulanamadı!"); }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Bilgileri Güncellendi!");
        }
    }
}
