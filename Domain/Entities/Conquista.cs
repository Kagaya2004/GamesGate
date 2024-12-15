using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Conquista : BaseEntity<int>
    {
        public Conquista()
        {

        }

        public Conquista(int id, Jogo? jogo, string descricao) : base(id)
        {
            Jogo = jogo;
            Descricao = descricao;
        }

        public string? Descricao { get; set; }
        public virtual Jogo? Jogo { get; set; }
    }
}
