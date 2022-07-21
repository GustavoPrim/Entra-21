namespace Entra21.BancoDados01.Ado.Net.Exercicio.Models
{
    internal class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeHabitantes { get; set; }
        public DateTime DataHoraFundacao { get; set; }
        public decimal Pib { get; set;}

        // Preencher com INNER JOIN
        public UnidadeFederativa UnidadeFederativa { get; set; }
    }
}
