using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                .IsRequired();
            builder.Property(x => x.Login)
                .IsRequired();
            builder.Property(x => x.Email)
                .IsRequired();
            builder.Property(x => x.Senha)
                .IsRequired();
            builder.Property(x => x.Status)
                .IsRequired();
            builder.Property(x => x.DataNascimento)
                .IsRequired();
            builder.Property(x => x.DataCriacao)
                .IsRequired();
            builder.Property(x => x.DataLogin)
                .IsRequired();
            builder.Property(x => x.Descricao)
                .IsRequired();
        }
    }
}
