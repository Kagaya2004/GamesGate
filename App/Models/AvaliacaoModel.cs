using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class AvaliacaoModel
    {
        public int Id { get; set; }
        public int? IdJogo { get; set; }
        public string Jogo { get; set; }
        public int? IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Comentario { get; set; }
        public DateTime DataComentario { get; set; }
        public double Classificacao { get; set; }
    }
}
