using EasyPush.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPushu.Data.Mappings
{
    // Para toda classe criada na pasta Entyties no Model será criada uma classe Map para que o entity  siga a configuração par criar a tabela no banco
    public class MapTbUser : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //O Entity criará a tabela User de acordo com essa configuração
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Nome).HasMaxLength(150).IsRequired();
        }
    }
}
