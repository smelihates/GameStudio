using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Entities
{
    class Game:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
