using MySql.Data.MySqlClient;
using System.Data;
namespace interdisciplinar
{
    class Conexaobd

    {
        private MySqlConnection conexao;

        public void ConectarBD()
        {
            conexao = new MySqlConnection("persist security info = false;" +
                                           "server=localhost;" +
                                           "database=gerenciamento_empresarial;" +
                                           "uid=root;pwd=;SslMode=none");
          
            conexao.Open();
        }

        public void AlterarTabelas(string sql)
        {
            ConectarBD();
            MySqlCommand comandos = new MySqlCommand(sql, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
        }

        public DataTable consultarTabelas(string sql)

        {
            ConectarBD();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexao.Close();
            return resultado;
        }
    }
}

