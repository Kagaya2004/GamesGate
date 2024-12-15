using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class UnitTestRepository
    {
        DateTime data = DateTime.Now;

        public partial class MyDbContext : DbContext
        {
            public DbSet<Avaliacao> Avaliacoes { get; set; }
            public DbSet<Biblioteca> Bibliotecas { get; set; }
            public DbSet<BibliotecaItem> BibliotecaItens { get; set; }
            public DbSet<Conquista> Conquistas { get; set; }
            public DbSet<Desenvolvedora> Desenvolvedoras { get; set; }
            public DbSet<Genero> Generos { get; set; }
            public DbSet<Jogo> Jogos { get; set; }
            public DbSet<JogoGenero> JogoGeneros { get; set; }
            public DbSet<Usuario> Usuarios { get; set; }

            #region Construtor
            public MyDbContext()
            {
                Database.EnsureCreated();
            }
            #endregion

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "GamesGate";
                var username = "root";
                var password = "K@gaya011526";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Password={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]
        public void TestInsertAvaliacoes()
        {
            using (var context = new MyDbContext())
            {
                var jogo = context.Jogos.FirstOrDefault(c => c.Id == 1);
                var usuario = context.Usuarios.FirstOrDefault(c => c.Id == 1);
                var avaliacao = new Avaliacao
                {
                    Jogo = jogo,
                    Usuario = usuario,
                    Comentario = "Meu jogo favorito",
                    DataComentario = data,
                    Classificacao = 5
                };
                context.Avaliacoes.Add(avaliacao);

                jogo = context.Jogos.FirstOrDefault(c => c.Id == 1);
                usuario = context.Usuarios.FirstOrDefault(c => c.Id == 2);
                avaliacao = new Avaliacao
                {
                    Jogo = jogo,
                    Usuario = usuario,
                    Comentario = "Jogo muito difícil, não consigo passar da Hornet :<",
                    DataComentario = DateTime.Now,
                    Classificacao = 1.5
                };
                context.Avaliacoes.Add(avaliacao);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListAvaliacoes()
        {
            using (var context = new MyDbContext())
            {
                foreach (var avaliacao in context.Avaliacoes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(avaliacao));
                }
            }
        }

        [TestMethod]
        public void TestInsertBibliotecas()
        {
            using (var context = new MyDbContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(context => context.Id == 1);
                var jogo1 = context.Jogos.FirstOrDefault(context => context.Id == 1);
                var jogo2 = context.Jogos.FirstOrDefault(context => context.Id == 2);

                Biblioteca biblioteca = new Biblioteca()
                {
                    Usuario = usuario
                };
                var lista = new List<BibliotecaItem>();
                {
                    new BibliotecaItem
                    {
                        Jogo = jogo1,
                        HorasJogadas = 300.0,
                        Biblioteca = biblioteca
                    };
                    new BibliotecaItem
                    {
                        Jogo = jogo2,
                        HorasJogadas = 200,
                        Biblioteca = biblioteca
                    };
                };

                biblioteca.ListaJogos = lista;
                context.Add(biblioteca);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListBibliotecas()
        {
            using (var context = new MyDbContext())
            {
                foreach (var biblioteca in context.Bibliotecas)
                {
                    Console.WriteLine(JsonSerializer.Serialize(biblioteca));
                }
            }
        }

        [TestMethod]
        public void TestListBibliotecaItens()
        {
            using (var context = new MyDbContext())
            {
                foreach (var bibliotecaItem in context.BibliotecaItens)
                {
                    Console.WriteLine(JsonSerializer.Serialize(bibliotecaItem));
                }
            }
        }

        [TestMethod]
        public void TestInsertConquistas()
        {
            using (var context = new MyDbContext())
            {
                var jogo1 = context.Jogos.FirstOrDefault(context => context.Id == 1);
                var jogo2 = context.Jogos.FirstOrDefault(context => context.Id == 2);

                var conquista = new Conquista()
                {
                    Descricao = "Abrace o Vazio",
                    Jogo = jogo1
                };
                context.Conquistas.Add(conquista);

                conquista = new Conquista()
                {
                    Descricao = "Cume da Montanha Celeste",
                    Jogo = jogo2
                };
                context.Conquistas.Add(conquista);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListConquistas()
        {
            using (var context = new MyDbContext())
            {
                foreach (var conquista in context.Conquistas)
                {
                    Console.WriteLine(JsonSerializer.Serialize(conquista));
                }
            }
        }

        [TestMethod]
        public void TestInsertDesenvolvedoras()
        {
            using (var context = new MyDbContext())
            {
                var desenvolvedora = new Desenvolvedora()
                {
                    Nome = "Team Cherry",
                    Pais = "Austrália",
                    Email = "teamcherry@gmail.com",
                    Site = "teamcherry.com",
                    Descricao = "Empresa australiana Indie"
                };
                context.Desenvolvedoras.Add(desenvolvedora);

                desenvolvedora = new Desenvolvedora()
                {
                    Nome = "Maddy Games",
                    Pais = "Canadá",
                    Email = "maddygames@gmail.com",
                    Site = "maddygames.com",
                    Descricao = "Empresa canadense Indie"
                };
                context.Desenvolvedoras.Add(desenvolvedora);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListDesenvolvedoras()
        {
            using (var context = new MyDbContext())
            {
                foreach (var desenvolvedora in context.Desenvolvedoras)
                {
                    Console.WriteLine(JsonSerializer.Serialize(desenvolvedora));
                }
            }
        }

        [TestMethod]
        public void TestInsertGeneros()
        {
            using (var context = new MyDbContext())
            {
                var genero = new Genero()
                {
                    Nome = "Metrodvania"
                };
                context.Generos.Add(genero);
                
                genero = new Genero()
                {
                    Nome = "Plataforma"
                };
                context.Generos.Add(genero);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListGeneros()
        {
            using (var context = new MyDbContext())
            {
                foreach (var genero in context.Generos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(genero));
                }
            }
        }

        [TestMethod]
        public void TestInsertJogos()
        {
            using (var context = new MyDbContext())
            {
                var desenvolvedora1 = context.Desenvolvedoras.FirstOrDefault(context => context.Id == 1);
                var desenvolvedora2 = context.Desenvolvedoras.FirstOrDefault(context => context.Id == 2);

                var jogo = new Jogo()
                { 
                    Nome = "Hollow Knight",
                    Descricao = "Se aventure no Reino de Hallownest",
                    DataLancamento = data,
                    Desenvolvedora = desenvolvedora1,
                };
                context.Jogos.Add(jogo);

                jogo = new Jogo()
                {
                    Nome = "Celeste",
                    Descricao = "Se desafie a atingir o Cume da Montanha Celeste",
                    DataLancamento = data,
                    Desenvolvedora = desenvolvedora2
                };
                context.Jogos.Add(jogo);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListJogos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var jogo in context.Jogos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(jogo));
                }
            }
        }

        [TestMethod]
        public void TestInsertJogoGeneros()
        {
            using (var context = new MyDbContext())
            {
                var jogo1 = context.Jogos.FirstOrDefault(context => context.Id == 1);
                var jogo2 = context.Jogos.FirstOrDefault(context => context.Id == 2);
                var genero1 = context.Generos.FirstOrDefault(context => context.Id == 1);
                var genero2 = context.Generos.FirstOrDefault(context => context.Id == 2);

                var jogoGenero = new JogoGenero()
                { 
                    Jogo = jogo1,
                    Genero = genero1,
                };
                context.JogoGeneros.Add(jogoGenero);

                jogoGenero = new JogoGenero()
                { 
                    Jogo = jogo2,
                    Genero = genero2
                };
                context.JogoGeneros.Add(jogoGenero);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListJogoGeneros()
        {
            using (var context = new MyDbContext())
            {
                foreach (var jogoGenero in context.JogoGeneros)
                {
                    Console.WriteLine(JsonSerializer.Serialize(jogoGenero));
                }
            }
        }

        [TestMethod]
        public void TestInsertUsuarios()
        {
            using (var context = new MyDbContext())
            {
                var usuario = new Usuario()
                {
                    Nome = "Kayky",
                    Login = "Kagaya",
                    Email = "kaykyogaya@gmail.com",
                    DataNascimento = DateTime.Parse("26/07/2004"),
                    DataCriacao = data,
                    DataLogin = data,
                    Senha = "K@gaya0112526",
                    Status = "Ativo",
                    Descricao = "Um simples jogador Indie"
                };
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListUsuarios()
        {
            using (var context = new MyDbContext())
            {
                foreach (var usuario in context.Usuarios)
                {
                    Console.WriteLine(JsonSerializer.Serialize(usuario));
                }
            }
        }
    }
}
