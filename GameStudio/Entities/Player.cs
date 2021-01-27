using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Entities
{
    public class Player:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
