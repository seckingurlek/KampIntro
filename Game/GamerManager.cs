using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
           userValidationService = userValidationService;
        }

        // bir sınıfın içine başka bi sınıf kullancaksan onu new leme
        public void Add(IGamerService gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            Console.WriteLine("Kayıt oldu");
        }

        public void Delete(IGamerService gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(IGamerService gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
