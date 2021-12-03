using EasyPush.Domain.Entities;
using EasyPushu.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPushu.Data.Context
{
    public class BancoDadosContext : DbContext
    {
        public BancoDadosContext(DbContextOptions<BancoDadosContext> options)
       : base(options) { }

        //"DBSets"
        public DbSet<User> User { get; set; }

        /// <summary>
        /// Estamos sobrescrevedo o método OnMedelCreating para que ele crie a tabela de acordo com o mapeamento que foi escrito na .Data.Mappings
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapTbUser());

            base.OnModelCreating(modelBuilder);
        }

    }
}
