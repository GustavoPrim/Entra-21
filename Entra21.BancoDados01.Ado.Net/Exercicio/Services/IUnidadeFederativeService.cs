using Entra21.BancoDados01.Ado.Net.Exercicio.Models;

namespace Entra21.BancoDados01.Ado.Net.Exercicio.Services
{
    internal interface IUnidadeFederativeService
    {
        void Cadastrar(UnidadeFederativa unidadeFederativa);
        void Editar(UnidadeFederativa unidadeFederativa);
        void Apagar(int id);
        List<UnidadeFederativa> ObterTodos();
        UnidadeFederativa ObterPorId(int id);
    }
}