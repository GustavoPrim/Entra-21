namespace Entra21.BancoDados01.Ado.Net.Exercicio.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeHabitantes { get; set; }
        public DateTime DataHoraFundacao { get; set; }
        public decimal Pib { get; set; }

        // preencher com INNER JOIN
        public UnidadeFederativa UnidadeFederativa { get; set; }
    }
}