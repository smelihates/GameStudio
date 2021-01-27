using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Entities
{
    class Sold : IEntity
    {
        public int Id { get; set; }

        public Player player { get; set; }

        public Game game { get; set; }

    }
}
