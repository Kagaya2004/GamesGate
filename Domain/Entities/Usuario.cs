using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public Usuario()
        {

        }

        public Usuario(int id, string nome, string login,
            string email, string senha, string status,
            DateTime dataNascimento, DateTime dataCriacao, 
            DateTime dataLogin, string descricao)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Email = email;
            Senha = senha;
            Status = status;
            DataNascimento = dataNascimento;
            DataCriacao = dataCriacao;
            DataLogin = dataLogin;
            Descricao = descricao;
        }

        public string? Nome { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Status { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataLogin { get; set; }
        public string? Descricao { get; set; }
    }
}
