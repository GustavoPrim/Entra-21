using System.Data;
using Entra21.BancoDados01.Ado.Net.Exercicio.DataBase;
using Entra21.BancoDados01.Ado.Net.Exercicio.Models;

namespace Entra21.BancoDados01.Ado.Net.Exercicio.Services
{
    internal class UnidadeFederativaService : IUnidadeFederativeService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM unidades_federativas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Cadastrar(UnidadeFederativa unidadeFederativa)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO unidades_federativas (nome, sigla) VALUES (@NOME, @SIGLA)";
            comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadeFederativa.Sigla);

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Editar(UnidadeFederativa unidadeFederativa)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE unidades_federativas SET nome = @NOME, sigla = @SIGLA WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadeFederativa.Sigla);
            comando.Parameters.AddWithValue("@ID", unidadeFederativa.Id);

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public UnidadeFederativa ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, sigla FROM unidades_federativas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaMemoria = new DataTable();
            tabelaMemoria.Load(comando.ExecuteReader());

            if (tabelaMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaMemoria.Rows[0];

            var unidadeFederativa = new UnidadeFederativa();
            unidadeFederativa.Id = Convert.ToInt32(primeiroRegistro["id"]);
            unidadeFederativa.Nome = primeiroRegistro["nome"].ToString();
            unidadeFederativa.Sigla = primeiroRegistro["sigla"].ToString();

            comando.Connection.Close();

            return unidadeFederativa;
        }

        public List<UnidadeFederativa> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, sigla FROM unidades_federativas";

            var tabelaMemoria = new DataTable();
            tabelaMemoria.Load(comando.ExecuteReader());

            var unidadesFederativas = new List<UnidadeFederativa>();

            for (var i = 0; i < tabelaMemoria.Rows.Count; i++)
            {
                var linha = tabelaMemoria.Rows[i];

                var unidadeFederativa = new UnidadeFederativa();

                unidadeFederativa.Id = Convert.ToInt32(linha["id"].ToString());
                unidadeFederativa.Nome = linha["nome"].ToString();
                unidadeFederativa.Sigla = linha["sigla"].ToString();

                unidadesFederativas.Add(unidadeFederativa);
            }
            comando.Connection.Close();

            return unidadesFederativas;
        }
    }
}