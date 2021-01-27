using GameStudio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign, List<Game> games );
        void Update(Campaign oldCampaign, Campaign newCampaign, List<Game> games);
        void Delete(Campaign campaign, List<Game> games);
        void List();
    }
}
