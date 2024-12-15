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
    public class JogoGeneroMap : IEntityTypeConfiguration<JogoGenero>
    {
        public void Configure(EntityTypeBuilder<JogoGenero> builder)
        {
            builder.ToTable("JogoGenero");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Jogo);
            builder.HasOne(x => x.Genero);
        }
    }
}
