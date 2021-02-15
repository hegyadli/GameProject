using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot.Types;

namespace GameProject.Concreate
{
    public class GameManager : IGameService
    {
        public void Add(Entities.Game game)
        {
            Console.WriteLine(game.GameName + "EKLEMDİ." + '\n');
        }

        public void Delete(Entities.Game game)
        {
            Console.WriteLine(game.GameName + "SİLİNDİ." + '\n');
        }

        public void Update(Entities.Game game)
        {
            Console.WriteLine(game.GameName + "GÜNCELLENDİ." + '\n');
        }
    }
}
