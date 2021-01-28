using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate (Gamer gamer)
        {
            if (gamer.BirthDate==2002 && gamer.FirstName=="Semih" &&
                gamer.Surname=="KUNDAKCI" && gamer.IdentityNumber==12345)
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
