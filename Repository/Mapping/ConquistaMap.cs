using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Mapping
{
    public class ConquistaMap : IEntityTypeConfiguration<Conquista>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Conquista> builder)
        {
            builder.ToTable("Conquistas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao)
                .IsRequired();
            builder.HasOne(x => x.Jogo)
                .WithMany()
                .HasConstraintName("FK_Jogo");
        }
    }
}
