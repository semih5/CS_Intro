using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                IdentityNumber = 12345,
                BirthDate = 2002,
                FirstName = "Semih",
                Surname = "KUNDAKCI"
            });
        }
    }
}
