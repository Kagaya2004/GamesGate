using AutoMapper;
using Domain.Base;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository.BaseRepository;
using Repository.Context;
using Service.Services;
using Services.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;
        DateTime data = DateTime.Now;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "127.0.0.1";
                var port = "3306";
                var database = "GamesGate";
                var username = "root";
                var password = "K@gaya011526";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, Usuario>();
            }).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestInsertUsuario()
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();
            var usuario = new Usuario
            {
                Nome = "Kayky",
                Login = "Kagaya",
                Email = "kaykyogaya@gmail.com",
                Senha = "K@gaya011526",
                DataNascimento = DateTime.Parse("26/07/2004"),
                DataCriacao = data,
                DataLogin = data,
                Status = "Ativo",
                Descricao = "Apenas um jogador Indie tranquilo"
            };

            var result = usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectUsuario()
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();

            var result = usuarioService.Get<Usuario>();
            Console.Write(JsonSerializer.Serialize(result));
        }
    }
}
