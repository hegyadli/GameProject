using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    class CampaignManager : ICampaingService
    {
        public void add(Campaign campaign)
        {
            Console.WriteLine("KAMPANYA EKLENDİ! : " + campaign.CampaingName + " İndirim Oranı: " + campaign.DiscountRate + '\n');
        }

        public void delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + "'NIN SÜRESİ DOLDUĞUNDAN KAMPANYA SİLİNDİ." + '\n');
        }

        public void update(Campaign campaign)
        {
            Console.WriteLine("KAMPANYA GÜNCELLENDİ! : " + campaign.CampaingName + " İndirim Oranı : " + campaign.DiscountRate + '\n');
        }
    }
}
