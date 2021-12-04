using EasyPush.Domain.Entities;
using EasyPushu.Data.Extensions;
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
        //Entity usa o nome dessa propriedades para dar nome a tabela criada
        public DbSet<User> User { get; set; }

      
        /// Estamos sobrescrevedo o método OnMedelCreating para que ele crie a tabela de acordo com o mapeamento que foi escrito na .Data.Mappings
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapTbUser());

            //Setando valores iniciais para a base de dados
            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
