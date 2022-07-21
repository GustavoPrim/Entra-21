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
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    AttachDbFilename=D:\Documents
                                    \ExercicioBancoDeDados01.mdf;Integrated
                                    Security=True;Connect Timeout=30";

            // define o caminho da conexão para o sqlconnect
            conexao.ConnectionString = connectionString;

            // abri a conexão com o banco de dados
            conexao.Open();

            return conexao;
        }
    }
}
