using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.Exercicio.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            // Instanciado objeto da classe SqlConnect para fazer select, insert, update, delete...
            SqlConnection conexao = new SqlConnection();

            // string com o caminho para conectar com o banco de dados
            var nomeBanco = "BancoDados";
            
            var caminhoCompleto = Directory.GetCurrentDirectory().Substring(0, AppContext.BaseDirectory.LastIndexOf("\\bin"));
            conexao.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={caminhoCompleto}\DataBase\{nomeBanco}.mdf;Integrated Security=True";

            // abri a conexão com o banco de dados
            conexao.Open();

            return conexao;
        }
    }
}