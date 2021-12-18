using GameBackEnd.Abstract;
using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEnd.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "HACI" && gamer.LastName == "Deniz" &&
                gamer.DateOfBirth == new DateTime(1995, 06, 18) && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
