using GameStudio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Abstract
{
    //Mernis doğrulaması olmadan yapılan internal test ortamı
   public  interface IPlayerCheckService
    {
        bool CheckIfRealPlayer(Player player);
    }
}
