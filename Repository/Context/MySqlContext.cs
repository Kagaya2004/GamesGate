using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Mapping;

namespace Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Avaliacao> Avaliacaos { get; set; }
        public DbSet<Biblioteca> Bibliotecas { get; set; }
        public DbSet<Conquista> Conquistas { get; set; }
        public DbSet<Desenvolvedora> Desenvolvedoras { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<JogoGenero> JogoGeneros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<BibliotecaItem> ListaJogos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Avaliacao>(new AvaliacaoMap().Configure);
            modelBuilder.Entity<Biblioteca>(new BibliotecaMap().Configure);
            modelBuilder.Entity<Conquista>(new ConquistaMap().Configure);
            modelBuilder.Entity<Desenvolvedora>(new DesenvolvedoraMap().Configure);
            modelBuilder.Entity<Genero>(new GeneroMap().Configure);
            modelBuilder.Entity<Jogo>(new JogoMap().Configure);
            modelBuilder.Entity<JogoGenero>(new JogoGeneroMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<BibliotecaItem>(new BibliotecaItemMap().Configure);
        }
    }
}
