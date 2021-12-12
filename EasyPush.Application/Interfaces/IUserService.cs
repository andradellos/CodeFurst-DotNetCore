using EasyPush.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPush.Application.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get();
    }
}
