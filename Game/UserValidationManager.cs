using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 19854 &&gamer.FirstName = "Engin" &&gamer.LastName == "Demirog" && gamer.IdNumber == 12345)
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
