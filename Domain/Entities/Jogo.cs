using Domain.Base;

namespace Domain.Entities
{
    public class Jogo : BaseEntity<int>
    {
        public Jogo()
        {

        }

        public Jogo(int id, string nome, string descricao,
            DateTime dataLancamento, Desenvolvedora? desenvolvedora)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            DataLancamento = dataLancamento;
            Desenvolvedora = desenvolvedora;
        }

        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataLancamento { get; set; }
        public virtual Desenvolvedora? Desenvolvedora { get; set; }
    }
}
