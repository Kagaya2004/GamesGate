namespace App.Models
{
    public class JogoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataLancamento { get; set; }
        public int? IdDesenvolvedora { get; set; }
        public string? Desenvolvedora { get; set; }
    }
}
