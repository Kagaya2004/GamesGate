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
    public class ConquistaMap : IEntityTypeConfiguration<Conquista>
    {
        public void Configure(EntityTypeBuilder<Conquista> builder)
        {
            builder.ToTable("Conquista");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao)
                .IsRequired();
            builder.HasOne(x => x.Jogo);
        }
    }
}
