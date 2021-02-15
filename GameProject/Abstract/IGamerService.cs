﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer game);
        void Update(Gamer game);
        void Delete(Gamer game);
    }
}
