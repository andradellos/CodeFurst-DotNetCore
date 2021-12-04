using EasyPush.Application.Interfaces;
using EasyPush.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EasyPush.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
