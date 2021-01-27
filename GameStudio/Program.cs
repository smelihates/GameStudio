using GameStudio.Abstract;
using GameStudio.Adapters;
using GameStudio.Concrete;
using GameStudio.Entities;
using System;

namespace GameStudio
{
    class Program
    {
        static void Main(string[] args)
        {

            //Oyun Fonksiyonları
            GameManager gameManager = new GameManager();

            Console.WriteLine("Oyun Ekleme -----------------------------------------");
            Game game1 = new Game { Id = 1, Name = "Sudoku", Price = 3.75 };
            gameManager.Add(game1);

            Game game2 = new Game { Id = 2, Name = "Puzle", Price = 4.50 };
            gameManager.Add(game2);

            Game game3 = new Game { Id = 3, Name = "Satranç", Price = 7.80 };
            gameManager.Add(game3);
            Console.WriteLine("");

            Console.WriteLine("Oyunları Listeleme -----------------------------------------");
            gameManager.List();
            Console.WriteLine("");

            Console.WriteLine("Oyun Bilgisini Güncelleme -----------------------------------------");
            Game game4 = new Game { Id = 4, Name = "Puzle 2.0", Price = 4.85 };
            gameManager.Update(game2, game4);
            Console.WriteLine("");

            //Console.WriteLine("Oyunları Listeleme -----------------------------------------");
            //gameManager.List();
            //Console.WriteLine("");

            //Console.WriteLine("Oyun Kaydını Sileme -----------------------------------------");
            //gameManager.Delete(game4);
            //Console.WriteLine("");

            //Console.WriteLine("Oyunları Listeleme -----------------------------------------");
            //gameManager.List();
            //Console.WriteLine("");

            //gameManager.Add(game3);
            //Console.WriteLine("");


            //Oyuncu Fonksiyonları
            Console.WriteLine("Oyuncuları Ekleme -----------------------------------------");
            //Mernis kontrolü yapar
            //BasePlayerManager playerManager = new PlayerManager(new MernisServiceAdapters());

            //mernis kontrolü yok-iç test
            BasePlayerManager playerManager = new PlayerManager(new PlayerCheckManager());

            Player player1 = new Player { Id = 1, FirstName = "Ahmet", LastName = "Demir", DateOfBirth = new DateTime(1983, 3, 20), NationalityId = "12345678910" };
            playerManager.Add(player1);

            Player player2 = new Player { Id = 2, FirstName = "Mehmet", LastName = "Hacı", DateOfBirth = new DateTime(1974, 5, 15), NationalityId = "47745678910" };
            playerManager.Add(player2);

            Player player3 = new Player { Id = 3, FirstName = "Tolga", LastName = "Avcı", DateOfBirth = new DateTime(1965, 7, 20), NationalityId = "15645678910" };
            playerManager.Add(player3);
            Console.WriteLine("");

            //Console.WriteLine("Oyuncuları Listeleme -----------------------------------------");
            //playerManager.List();
            //Console.WriteLine("");

            Console.WriteLine("Oyuncuyu Güncelleme -----------------------------------------");
            playerManager.Update(player3, new Player { Id = 3, FirstName = "Tolga", LastName = "Halıcı", DateOfBirth = new DateTime(1965, 7, 20), NationalityId = "15645678910" });
            Console.WriteLine(" ");

            Console.WriteLine("Oyuncuları Listeleme -----------------------------------------");
            playerManager.List();
            Console.WriteLine("");

            //Console.WriteLine("Oyuncu Silme -----------------------------------------");
            //playerManager.Delete(player2);
            //Console.WriteLine("");

            //Console.WriteLine("Oyuncuları Listeleme -----------------------------------------");
            //playerManager.List();
            //Console.WriteLine("");

            //Oyun Satış FOnksiyonları
            Console.WriteLine("Oyun Satışı-----------------------------------------");
            SoldManager soldManager = new SoldManager();
            soldManager.Sold(player1, game1);
            soldManager.Sold(player1, game2);
            soldManager.Sold(player3, game1);
            soldManager.Sold(player3, game4);
            Console.WriteLine("");

            //Console.WriteLine("Oyun Satış Listeleme-----------------------------------------");
            //soldManager.List();
            //Console.WriteLine("");

            //Kampanya Fonksiyonları            
            Console.WriteLine("Oyunların Kampanya Öncesi Fiyatları-----------------------------------------");
            gameManager.List();


            Console.WriteLine("Kampanya Ekleme-----------------------------------------");
            CampaignManager campaignManager = new CampaignManager();

            Campaign campaign1 = new Campaign { Id = 1, Name = "Efsane Cuma", DiscountRate = 13 };
            campaignManager.Add(campaign1,gameManager.ListOfGame );

            //Campaign campaign2 = new Campaign { Id = 2, Name = "Yaz Sonu", DiscountRate = 7 };
            //campaignManager.Add(campaign2, gameManager.ListOfGame);

            //Campaign campaign3 = new Campaign { Id = 3, Name = "Yılbaşı", DiscountRate = 6 };
            //campaignManager.Add(campaign3, gameManager.ListOfGame);
            Console.WriteLine("");

            //Console.WriteLine("Kampanya'yı geri kaldırma-----------------------------------------");
            //campaignManager.Delete(campaign3, gameManager.ListOfGame);


            Console.WriteLine("Mevcut Kampanya Bilgileri-----------------------------------------");
            campaignManager.List();
            Console.WriteLine("");

            Console.WriteLine("Oyunların Kampanya Fiyatları-----------------------------------------");
            gameManager.List();
            Console.WriteLine("");

            Console.WriteLine("Kampanya Sonu Fiyatları-----------------------------------------");
            campaignManager.Delete(campaign1, gameManager.ListOfGame);

            Console.WriteLine("Mevcut Kampanya Bilgileri-----------------------------------------");
            campaignManager.List();
            Console.WriteLine("");

            Console.WriteLine("Oyunların Kampanya Fiyatları-----------------------------------------");
            gameManager.List();
            Console.WriteLine("");
        }
    }
}
