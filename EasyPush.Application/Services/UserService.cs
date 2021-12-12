using EasyPush.Application.Interfaces;
using EasyPush.Application.ViewModels;
using EasyPush.Domain.Entities;
using EasyPush.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPush.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository pUserRepository)
        {
            this.userRepository = pUserRepository;
        }
        public List<UserViewModel> Get()
        {
            IEnumerable<User> listUser = this.userRepository.GetAll();
            List<UserViewModel> VM_User = new List<UserViewModel>();

            foreach (User item in listUser)            
                VM_User.Add(new UserViewModel { Id = item.Id, Email = item.Email, Nome = item.Nome });
            

            return VM_User;
        }
    }
}
