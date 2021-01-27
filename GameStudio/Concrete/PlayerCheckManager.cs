using GameStudio.Abstract;
using GameStudio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Concrete
{
     class PlayerCheckManager : IPlayerCheckService
    {
        //Bu servis ile Mernis doğrulaması yapılmadan test edilebilir. 
        public bool CheckIfRealPlayer(Player player)
        {
            return true;
        }
    }
}
