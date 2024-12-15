using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JogoGenero : BaseEntity<int>
    {
        public JogoGenero()
        {

        }

        public JogoGenero(int id, Jogo? jogo, Genero? genero) : base(id)
        {
            Jogo = jogo;
            Genero = genero;
        }

        public Genero? Genero { get; set; }
        public Jogo? Jogo { get; set; }
    }
}
