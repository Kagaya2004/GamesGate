using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Mapping
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("Avaliacoes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Comentario)
                .IsRequired();
            builder.Property(x => x.DataComentario)
                .IsRequired();
            builder.Property(x => x.Classificacao)
                .IsRequired();
            builder.HasOne(x => x.Jogo)
                .WithMany()
                .HasConstraintName("FK_Jogo");
            builder.HasOne(x => x.Usuario)
                .WithMany()
                .HasConstraintName("FK_Usuario");
        }
    }
}
