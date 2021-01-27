using GameStudio.Abstract;
using GameStudio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Concrete
{
    class SoldManager : ISoldService
    {
        List<Sold> ListOfSold = new List<Sold>();

        public void List()
        {
            foreach (var item in ListOfSold)
            {
                Console.WriteLine("{0,-2}-{1,-10} isimli kullanıcıya {2,-10} isimli oyun, {3:0.00} TL'ye satıldı.", item.Id, item.player.FirstName, 
                    item.game.Name, item.game.Price);
            }
        }

        public void Sold(Player _player, Game _game)
        {
            int _id = 0;
            _id = ListOfSold.Count + 1;
            ListOfSold.Add(new Sold { Id = _id, game = _game, player = _player });
            Console.WriteLine("{0,-2}-{1,-10} isimli kullanıcıya {2,-10} isimli oyun, {3:0.00} TL'ye satıldı.", _id, _player.FirstName, _game.Name, _game.Price);
        }
    }
}
