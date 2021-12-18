using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEnd.Abstract
{
    internal interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
