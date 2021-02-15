using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    public class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + campaign.CampaingName + " ile " + game.GameName + " oyununu aldı." + '\n');
        }

        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + game.GameName + " oyununu aldı." + '\n');
        }
    }
}
