﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Mapping
{
    public class DesenvolvedoraMap : IEntityTypeConfiguration<Desenvolvedora>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Desenvolvedora> builder)
        {
            builder.ToTable("Desenvolvedoras");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                .IsRequired();
            builder.Property(x => x.Pais)
                .IsRequired();
            builder.Property(x => x.Site)
                .IsRequired();
            builder.Property(x => x.Email)
                .IsRequired();
            builder.Property(x => x.Descricao)
                .IsRequired();
        }
    }
}
