using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Avaliacao : BaseEntity<int>
    {
        public Avaliacao()
        {

        }

        public Avaliacao(int id, Jogo? jogo, Usuario? usuario,
            string comentario, DateTime dataComentario, double classificacao)
        {
            Id = id;
            Jogo = jogo;
            Usuario = usuario;
            Comentario = comentario;
            DataComentario = dataComentario;
            Classificacao = classificacao;
        }

        public virtual Jogo? Jogo { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public string? Comentario { get; set; }
        public DateTime? DataComentario { get; set; }
        public double? Classificacao { get; set; }
    }
}
