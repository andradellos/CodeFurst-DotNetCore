using EasyPush.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPushu.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        //Métodos de extensão
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                         new User { Id = Guid.Parse("8dd9ac15-cd00-42d4-a3b8-eb9e20825a04"), Email = "defalt@emai.com", Nome = "User Defalt" }
                        );

            return builder;
        }
    }
}
