using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    public class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }

        public bool Validate(object gamer)
        {
            throw new NotImplementedException();
        }
    }
}
