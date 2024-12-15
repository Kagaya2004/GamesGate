using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Mapping
{
    public class BibliotecaMap : IEntityTypeConfiguration<Biblioteca>
    {
        public void Configure(EntityTypeBuilder<Biblioteca> builder)
        {
            builder.ToTable("Biblioteca");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Usuario);
            builder.HasMany(x => x.ListaJogos)
                .WithOne(x => x.Biblioteca)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class BibliotecaItemMap : IEntityTypeConfiguration<BibliotecaItem>
    {
        public void Configure(EntityTypeBuilder<BibliotecaItem> builder)
        {
            builder.ToTable("BibliotecaItem");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.HorasJogadas)
                .IsRequired();
            builder.HasOne(x => x.Jogo);
            builder.HasOne(x => x.Biblioteca)
                .WithMany(x => x.ListaJogos)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
