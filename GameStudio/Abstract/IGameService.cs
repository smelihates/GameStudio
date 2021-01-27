using GameStudio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game oldGame, Game newGame);
        void Delete(Game game);
        void List();

    }
}
