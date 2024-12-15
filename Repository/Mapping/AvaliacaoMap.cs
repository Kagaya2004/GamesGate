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
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("Avaliacao");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Comentario)
                .IsRequired();
            builder.Property(x => x.DataComentario)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Classificacao)
                .IsRequired();
            builder.HasOne(x => x.Jogo);
            builder.HasOne(x => x.Usuario);
        }
    }
}
