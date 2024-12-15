using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Mapping
{
    public class JogoGeneroMap : IEntityTypeConfiguration<JogoGenero>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<JogoGenero> builder)
        {
            builder.ToTable("JogoGeneros");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Jogo)
                .WithMany()
                .HasConstraintName("FK_Jogo");
            builder.HasOne(x => x.Genero)
                .WithMany()
                .HasConstraintName("FK_Genero");
        }
    }
}
