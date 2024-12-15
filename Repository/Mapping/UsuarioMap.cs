using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasConversion(x => x!.ToString(), x => x);
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
                .IsRequired()
                .HasDefaultValue(DateTime.Now);
            builder.Property(x => x.DataLogin)
                .IsRequired();
            builder.Property(x => x.Descricao)
                .IsRequired();
        }
    }
}
