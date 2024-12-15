using Domain.Entities;

namespace App.Models
{
    public class BibliotecaModel
    {
        public BibliotecaModel()
        {
            ListaJogos = new List<BibliotecaItem>();
        }

        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public List<BibliotecaItem> ListaJogos { get; set; }
    }

    public class BibliotecaItemModel
    {
        public int Id { get; set; }
        public int IdJogo { get; set; }
        public string? Jogo { get; set; }
        public float HorasJogadas { get; set; }
        public int IdBiblioteca { get; set; }
    }
}
