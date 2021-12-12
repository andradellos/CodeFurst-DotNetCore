using EasyPush.Application.Interfaces;
using EasyPush.Application.Services;
using EasyPush.Domain.Interfaces;
using EasyPushu.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EasyPush.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services
            services.AddScoped<IUserService, UserService>();
            #endregion

            #region Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion

        }
    }
}
