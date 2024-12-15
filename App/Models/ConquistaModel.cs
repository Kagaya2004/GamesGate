using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class ConquistaModel
    {
        public int Id { get; set; }
        public int IdJogo { get; set; }
        public string? Jogo { get; set; }
        public string Descricao { get; set; }
    }
}
