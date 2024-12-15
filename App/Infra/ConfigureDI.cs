using App.Cadastros;
using App.Models;
using App.Outros;
using AutoMapper;
using Domain.Base;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository.BaseRepository;
using Repository.Context;
using Service.Services;

namespace App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            #region Banco de Dados
            var strCon = File.ReadAllText("D:\\Kayky Ogaya\\Documents\\IFSP\\6° Semestre\\POE\\GamesGate\\SolucaoGamesGate\\App\\Config\\Config.txt");

            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine).EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            });
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Avaliacao>, BaseRepository<Avaliacao>>();
            Services.AddScoped<IBaseRepository<Biblioteca>, BaseRepository<Biblioteca>>();
            Services.AddScoped<IBaseRepository<BibliotecaItem>, BaseRepository<BibliotecaItem>>();
            Services.AddScoped<IBaseRepository<Conquista>, BaseRepository<Conquista>>();
            Services.AddScoped<IBaseRepository<Desenvolvedora>, BaseRepository<Desenvolvedora>>();
            Services.AddScoped<IBaseRepository<Genero>, BaseRepository<Genero>>();
            Services.AddScoped<IBaseRepository<Jogo>, BaseRepository<Jogo>>();
            Services.AddScoped<IBaseRepository<JogoGenero>, BaseRepository<JogoGenero>>();
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Avaliacao>, BaseService<Avaliacao>>();
            Services.AddScoped<IBaseService<Biblioteca>, BaseService<Biblioteca>>();
            Services.AddScoped<IBaseService<BibliotecaItem>, BaseService<BibliotecaItem>>();
            Services.AddScoped<IBaseService<Conquista>, BaseService<Conquista>>();
            Services.AddScoped<IBaseService<Desenvolvedora>, BaseService<Desenvolvedora>>();
            Services.AddScoped<IBaseService<Genero>, BaseService<Genero>>();
            Services.AddScoped<IBaseService<Jogo>, BaseService<Jogo>>();
            Services.AddScoped<IBaseService<JogoGenero>, BaseService<JogoGenero>>();
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            #endregion

            #region Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroAvaliacao, CadastroAvaliacao>();
            Services.AddTransient<CadastroBiblioteca, CadastroBiblioteca>();
            Services.AddTransient<CadastroConquista, CadastroConquista>();
            Services.AddTransient<CadastroDesenvolvedora, CadastroDesenvolvedora>();
            Services.AddTransient<CadastroGenero, CadastroGenero>();
            Services.AddTransient<CadastroJogo, CadastroJogo>();
            Services.AddTransient<CadastroJogoGenero, CadastroJogoGenero>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            #endregion

            #region Mappings
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>();
                config.CreateMap<Avaliacao, AvaliacaoModel>()
                    .ForMember(d => d.IdJogo, d => d.MapFrom(x => x.Jogo!.Id))
                    .ForMember(d => d.Jogo, d => d.MapFrom(x => x.Jogo!.Nome))
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome));
                config.CreateMap<Biblioteca, BibliotecaModel>()
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome));
                config.CreateMap<BibliotecaItem, BibliotecaItemModel>()
                    .ForMember(d => d.IdJogo, d => d.MapFrom(x => x.Jogo!.Id))
                    .ForMember(d => d.Jogo, d => d.MapFrom(x => x.Jogo!.Nome));
                config.CreateMap<Conquista, ConquistaModel>()
                    .ForMember(d => d.IdJogo, d => d.MapFrom(x => x.Jogo!.Id))
                    .ForMember(d => d.Jogo, d => d.MapFrom(x => x.Jogo!.Nome));
                config.CreateMap<Desenvolvedora, DesenvolvedoraModel>();
                config.CreateMap<Genero, GeneroModel>();
                config.CreateMap<Jogo, JogoModel>()
                    .ForMember(d => d.IdDesenvolvedora, d => d.MapFrom(x => x.Desenvolvedora!.Id))
                    .ForMember(d => d.Desenvolvedora, d => d.MapFrom(x => x.Desenvolvedora!.Nome));
                config.CreateMap<JogoGenero, JogoGeneroModel>()
                    .ForMember(d => d.IdGenero, d => d.MapFrom(x => x.Genero!.Id))
                    .ForMember(d => d.Genero, d => d.MapFrom(x => x.Genero!.Nome))
                    .ForMember(d => d.IdJogo, d => d.MapFrom(x => x.Jogo!.Id))
                    .ForMember(d => d.Jogo, d => d.MapFrom(x => x.Jogo!.Nome));                    
            }).CreateMapper());
            #endregion

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
