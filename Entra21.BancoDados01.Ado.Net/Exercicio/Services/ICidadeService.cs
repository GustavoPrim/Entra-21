using Entra21.BancoDados01.Ado.Net.Exercicio.Models;

namespace Entra21.BancoDados01.Ado.Net.Exercicio.Services
{
    internal interface ICidadeService
    {
        void Cadastrar(Cidade cidade);
        void Apagar(int id);
        void Editar(Cidade cidade);
        Cidade ObterPorId(int id);
        List<Cidade> ObterTodos();
    }
}
