using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Genero : BaseEntity<int>
    {
        public Genero()
        {

        }

        public Genero(int id, string nome) : base(id)
        {
            Nome = nome;
        }

        public string? Nome { get; set; }
    }
}
