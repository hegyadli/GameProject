using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaingService
    {
        void add(Campaign campaign);
        void update(Campaign campaign);
        void delete(Campaign campaign);
    }
}
