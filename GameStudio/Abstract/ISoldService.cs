using GameStudio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Abstract
{
    interface ISoldService
    {
        void Sold(Player player , Game game);

        void List();
    }
}
