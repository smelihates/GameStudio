using GameStudio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Abstract
{
    interface IPlayerService
    {
        void Add(Player player);
        void Update(Player oldPlayer, Player newPlayer);
        void Delete(Player player);
        void List();

    }
}
