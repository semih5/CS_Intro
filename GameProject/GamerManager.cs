using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Registered.");
            }
            else
            {
                Console.WriteLine("Verification failed. Register failed.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Registration deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Registration updated.");
        }
    }
}
