using GameStudio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Abstract
{
      public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Add(Player player)
        {
            
        }

        public virtual void Delete(Player player)
        {
            throw new NotImplementedException();
        }

        public virtual void List()
        {
            throw new NotImplementedException();
        }

        public virtual void Update(Player oldPlayer, Player newPlayer)
        {
            throw new NotImplementedException();
        }
    }
}
