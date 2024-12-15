using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class JogoGeneroModel
    {
        public int Id { get; set; }
        public int IdGenero { get; set; }
        public string Genero { get; set; }
        public int IdJogo { get; set; }
        public string Jogo { get; set; }
    }
}
