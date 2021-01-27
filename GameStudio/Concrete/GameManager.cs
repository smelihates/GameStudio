using GameStudio.Abstract;
using GameStudio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Concrete
{

    class GameManager : IGameService
    {
        public List<Game> ListOfGame = new List<Game>();

        public void Add(Game game)
        {
            ListOfGame.Add(game);
            Console.WriteLine("{0,-10} isimli oyun sisteme eklendi.", game.Name);
        }


        public void Delete(Game game)
        {
            Console.WriteLine("{0,-10} isimli oyun sistemden silindi.", game.Name);

            ListOfGame.Remove(game);
        }

        public void List()
        {
            Console.WriteLine("G.Id - G.Name - G.Price");
            Console.WriteLine("------------------------");
            foreach (var game in ListOfGame)
            {
                Console.WriteLine("{0,-2} - {1,-10} - {2:0.00} TL", game.Id, game.Name, game.Price);
            }
        }

        public void Update(Game oldGame, Game newGame)
        {
            Console.WriteLine("G.Id - G.Name - G.Price");
            Console.WriteLine("------------------------");
            Console.WriteLine("{0,-2} - {1,-10} - {2:0.00} TL bilgileri,", oldGame.Id, oldGame.Name, oldGame.Price);

            ListOfGame.Remove(oldGame);
            ListOfGame.Add(newGame);
            Console.WriteLine("{0,-2} - {1,-10} - {2:0.00} TL olarak güncellendi.", newGame.Id, newGame.Name, newGame.Price);


            Console.WriteLine();
        }
    }
}
