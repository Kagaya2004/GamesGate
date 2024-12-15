using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Text.Json;

namespace Test
{
    [TestClass]
    public class UnitTestDomain
    {
        DateTime data = DateTime.Now;

        [TestMethod]
        public void TestAvaliacao()
        {
            Usuario usuario = new Usuario(1, "Kayky", "Kagaya", "kaykyogaya@gmail.com", "K@gaya01", "Ativo", data, data, data, "descricao");
            Desenvolvedora desenvolvedora = new Desenvolvedora(1, "Team Cherry", "Austrália", "site", "teamcherry@gmail.com", "descricao");
            Jogo jogo = new Jogo(1, "Hollow Knight", "Descrição", data, desenvolvedora);
            Avaliacao avaliacao = new Avaliacao(1, jogo, usuario, "comentário", data, 5);
            Debug.Write(JsonSerializer.Serialize(avaliacao));
            Assert.AreEqual(avaliacao.Usuario, usuario);
            Assert.AreEqual(avaliacao.Jogo, jogo);
            Assert.AreEqual(avaliacao.Comentario, "comentário");
            Assert.AreEqual(avaliacao.DataComentario, data);
            Assert.AreEqual(avaliacao.Classificacao, 5);
        }

        [TestMethod]
        public void TestBiblioteca()
        {
            Usuario usuario = new Usuario(1, "Kayky", "Kagaya", "kaykyogaya@gmail.com", "K@gaya01", "Ativo", data, data, data, "descricao");
            Desenvolvedora desenvolvedora = new Desenvolvedora(1, "Team Cherry", "Austrália", "site", "teamcherry@gmail.com", "descricao");
            Jogo jogo = new Jogo(1, "Hollow Knight", "Descrição", data, desenvolvedora);
            List<BibliotecaItem> ListaJogos = new List<BibliotecaItem>();
            BibliotecaItem bibliotecaItem = new BibliotecaItem(1, jogo, 0, null);
            Avaliacao avaliacao = new Avaliacao(1, jogo, usuario, "comentário", data, 5);
            Debug.Write(JsonSerializer.Serialize(avaliacao));
            Assert.AreEqual(avaliacao.Usuario, usuario);
            Assert.AreEqual(avaliacao.Jogo, jogo);
            Assert.AreEqual(avaliacao.Comentario, "comentário");
            Assert.AreEqual(avaliacao.DataComentario, data);
            Assert.AreEqual(avaliacao.Classificacao, 5);
            Biblioteca biblioteca = new Biblioteca(1, ListaJogos, usuario);
        }

        [TestMethod]
        public void TestConquista()
        {
            Desenvolvedora desenvolvedora = new Desenvolvedora(1, "Team Cherry", "Austrália", "site", "teamcherry@gmail.com", "descricao");
            Jogo jogo = new Jogo(1, "Hollow Knight", "Se aventure no Reino de Hallownest", data, desenvolvedora);
            Conquista conquista = new Conquista(1, jogo, "Abrace o Vazio");
            Debug.Write(JsonSerializer.Serialize(conquista));
            Assert.AreEqual(conquista.Jogo, jogo);
            Assert.AreEqual(conquista.Descricao, "Abrace o Vazio");
        }

        [TestMethod]
        public void TestDesenvolvedora()
        {
            Desenvolvedora desenvolvedora = new Desenvolvedora(1, "Team Cherry", "Austrália", "site", "teamcherry@gmail.com", "descricao");
            Debug.Write(JsonSerializer.Serialize(desenvolvedora));
            Assert.AreEqual(desenvolvedora.Nome, "Team Cherry");
            Assert.AreEqual(desenvolvedora.Pais, "Austrália");
            Assert.AreEqual(desenvolvedora.Site, "site");
            Assert.AreEqual(desenvolvedora.Email, "teamcherry@gmail.com");
            Assert.AreEqual(desenvolvedora.Descricao, "descricao");
        }

        [TestMethod]
        public void TestGenero()
        {
            Genero genero = new Genero(1, "Metrodvania");
            Debug.Write(JsonSerializer.Serialize(genero));
            Assert.AreEqual(genero.Nome, "Metrodvania");
        }

        [TestMethod]
        public void TestJogo()
        {
            Desenvolvedora desenvolvedora = new Desenvolvedora(1, "Team Cherry", "Austrália", "site", "teamcherry@gmail.com", "descricao");
            Jogo jogo = new Jogo(1, "Hollow Knight", "Se aventure no Reino de Hallownest", data, desenvolvedora);
            Debug.Write(JsonSerializer.Serialize(jogo));
            Assert.AreEqual(jogo.Nome, "Hollow Knight");
            Assert.AreEqual(jogo.Descricao, "Se aventure no Reino de Hallownest");
            Assert.AreEqual(jogo.DataLancamento, data);
            Assert.AreEqual(jogo.Desenvolvedora, desenvolvedora);
        }

        [TestMethod]
        public void TestJogoGenero()
        {
            Desenvolvedora desenvolvedora = new Desenvolvedora(1, "Team Cherry", "Austrália", "site", "teamcherry@gmail.com", "descricao");
            Genero genero = new Genero(1, "Metrodvania");
            Jogo jogo = new Jogo(1, "Hollow Knight", "Se aventure no Reino de Hallownest", data, desenvolvedora);
            JogoGenero jogoGenero = new JogoGenero(1, jogo, genero);
            Debug.Write(JsonSerializer.Serialize(jogoGenero));
            Assert.AreEqual(jogoGenero.Jogo, jogo);
            Assert.AreEqual(jogoGenero.Genero, genero);
        }

        [TestMethod]
        public void TestUsuario()
        {
            Usuario usuario = new Usuario(1, "Kayky", "Kagaya", "kaykyogaya@gmail.com", "K@gaya01", "Ativo", data, data, data, "descricao");
            Debug.Write(JsonSerializer.Serialize(usuario));
            Assert.AreEqual(usuario.Nome, "Kayky");
            Assert.AreEqual(usuario.Login, "Kagaya");
            Assert.AreEqual(usuario.Email, "kaykyogaya@gmail.com");
            Assert.AreEqual(usuario.Senha, "K@gaya01");
            Assert.AreEqual(usuario.Status, "Ativo");
            Assert.AreEqual(usuario.DataNascimento, data);
            Assert.AreEqual(usuario.DataCriacao, data);
            Assert.AreEqual(usuario.DataLogin, data);
            Assert.AreEqual(usuario.Descricao, "descricao");
        }
    }
}