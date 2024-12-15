using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mapping
{
    public class JogoMap : IEntityTypeConfiguration<Jogo>
    {
        public void Configure(EntityTypeBuilder<Jogo> builder)
        {
            builder.ToTable("Jogo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                .IsRequired();
            builder.Property(x => x.Descricao)
                .IsRequired();
            builder.Property(x => x.DataLancamento)
                .IsRequired();
            builder.HasOne(x => x.Desenvolvedora)
                .WithMany()
                .HasConstraintName("FK_Desenvolvedora");
        }
    }
}
