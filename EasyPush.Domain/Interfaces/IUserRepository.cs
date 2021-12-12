using EasyPush.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPush.Domain.Interfaces
{
   public interface IUserRepository
    {
        IEnumerable<User> GetAll();
    }
}
