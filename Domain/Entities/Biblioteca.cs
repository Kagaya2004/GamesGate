using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Biblioteca : BaseEntity<int>
    {
        public Biblioteca()
        {
            ListaJogos = new List<BibliotecaItem>();
        }

        public Biblioteca(int id, List<BibliotecaItem> listaJogos, Usuario? usuario) : base(id)
        {
            Usuario = usuario;
            ListaJogos = listaJogos;
        }

        public virtual Usuario? Usuario { get; set; }
        public virtual List<BibliotecaItem> ListaJogos { get; set; }
    }

    public class BibliotecaItem : BaseEntity<int>
    {
        public BibliotecaItem()
        {

        }

        public BibliotecaItem(int id, Jogo jogo, float horasJogadas, Biblioteca biblioteca) : base(id)
        {
            Jogo = jogo;
            HorasJogadas = horasJogadas;
            Biblioteca = biblioteca;
        }

        public virtual Jogo? Jogo{ get; set; }
        public float HorasJogadas {  get; set; }
        [JsonIgnore]
        public virtual Biblioteca? Biblioteca { get; set; }
    }
}
