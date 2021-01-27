using GameStudio.Abstract;
using GameStudio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Concrete
{
    class CampaignManager : ICampaignService
    {
        List<Campaign> ListOfCampaign = new List<Campaign>();

        public void Add(Campaign campaign, List<Game> games)
        {
            ListOfCampaign.Add(campaign);
            Console.WriteLine("{0,-10} isimli kampanya sisteme eklendi.", campaign.Name);

            UpdatePrice(campaign, games);
        }

        public void Delete(Campaign campaign, List<Game> games)
        {

            Console.WriteLine("{0,-10} isimli kampanya sistemden kaldırıldı.", campaign.Name);
            double OldRate = campaign.DiscountRate;
            ReturnPrice(campaign, games);
            ListOfCampaign.Remove(campaign);
        }

        public void List()
        {
            Console.WriteLine("C.Id - C.Name - Discount Rate");
            Console.WriteLine("------------------------");
            foreach (var item in ListOfCampaign)
            {
                Console.WriteLine("{0,-2} - {1,-10} - {2:0.00} %", item.Id, item.Name, item.DiscountRate);
            }
        }

        public void Update(Campaign oldCampaign, Campaign newCampaign, List<Game> games)
        {
            Console.WriteLine("C.Id - C.Name - Discount Rate");
            Console.WriteLine("------------------------");
            Console.WriteLine("{0,-2} - {1,-10} - {2:0.00} bilgileri,", oldCampaign.Id, oldCampaign.Name, oldCampaign.DiscountRate);

            ListOfCampaign.Remove(oldCampaign);
            ListOfCampaign.Add(newCampaign);
            Console.WriteLine("{0,-2} - {1,-10} - {2:0.00} olarak güncellenmdi.", newCampaign.Id, newCampaign.Name, newCampaign.DiscountRate);
            ReturnPrice(oldCampaign, games);
            UpdatePrice(newCampaign, games);
        }

        private void UpdatePrice(Campaign campaign ,List<Game> games)
        {
            foreach (var game in games)
            {
                game.Price = game.Price * (100 - campaign.DiscountRate) / 100;
            }
        }

        private void ReturnPrice(Campaign campaign, List<Game> games)
        {
            foreach (var game in games)
            {
                game.Price = game.Price * 100 / (100 - campaign.DiscountRate);
            }
        }

    }
}
