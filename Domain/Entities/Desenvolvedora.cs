﻿using Domain.Base;

namespace Domain.Entities
{
    public class Desenvolvedora : BaseEntity<int>
    {
        public Desenvolvedora()
        {

        }

        public Desenvolvedora(int id, string nome, string pais,
            string site, string email, string descricao) : base(id)
        {
            Nome = nome;
            Pais = pais;
            Site = site;
            Email = email;
            Descricao = descricao;
        }

        public string? Nome { get; set; }
        public string? Pais { get; set; }
        public string? Site { get; set; }
        public string? Email { get; set; }
        public string? Descricao { get; set; }
    }
}
