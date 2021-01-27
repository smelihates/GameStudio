using GameStudio.Abstract;
using GameStudio.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        List<Player> ListOfPlayers = new List<Player>();

        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player))
            {
                ListOfPlayers.Add(player);
                //Console.WriteLine("Id - P.First & Last Name - P.Birth Date - P.TC.");
                //Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("{0,-2} - {1,-10} {2,-10} - {3:d} - {4,-11} oyuncu kaydı oluşturuldu.", player.Id, player.FirstName, player.LastName, player.DateOfBirth, player.NationalityId);

            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı kaydı");
            }
        }

        public override void Update(Player oldPlayer, Player newPlayer)
        {
            if (_playerCheckService.CheckIfRealPlayer(newPlayer))
            {
                ListOfPlayers.Add(newPlayer);
                ListOfPlayers.Remove(oldPlayer);

                Console.WriteLine("Id - P.First & Last Name - P.Birth Date - P.TC.");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("{0,-2} - {1,-10} {2,-10} - {3:d} - {4,-11} bilgileri,", oldPlayer.Id, oldPlayer.FirstName, oldPlayer.LastName, oldPlayer.DateOfBirth, oldPlayer.NationalityId);
                Console.WriteLine("{0,-2} - {1,-10} {2,-10} - {3:d} - {4,-11} olarak güncellendi.", newPlayer.Id, newPlayer.FirstName, newPlayer.LastName, newPlayer.DateOfBirth, newPlayer.NationalityId);
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı kaydı");
            }
        }

        public override void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " isimli kullanıcı sistemden silindi.");
            ListOfPlayers.Remove(player);
        }

        public override void List()
        {
            Console.WriteLine("Id - P.First & Last Name - P.Birth Date - P.TC.");
            Console.WriteLine("--------------------------------------------------------");

            foreach (var item in ListOfPlayers)
            {
                Console.WriteLine("{0,-2} - {1,-10} {2,-10} - {3:d} - {4,-11} ", item.Id, item.FirstName, item.LastName, (item.DateOfBirth), item.NationalityId);
            }
        }



    }
}
