using EasyPush.Domain.Entities;
using EasyPush.Domain.Interfaces;
using EasyPushu.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPushu.Data.Repositories
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(BancoDadosContext context) 
            : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }
    }
}
