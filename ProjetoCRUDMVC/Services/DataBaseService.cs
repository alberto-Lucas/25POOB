using System.Data;
using System.Data.SqlClient;

namespace ProjetoCRUDMVC.Services
{
    //Classe dentro da camada Service
    //Responsavel pela conexão com o banco de dados
    //e execução dos comandos no banco

    //Importar as bibliotecas
    //using System.Data;
    //using System.Data.SqlClient;
    public class DataBaseService
    {
        //Método privado que irá retornar a
        //conexão com o banco
        private SqlConnection GetConnection()
        {
            //Variavel para armazenar a conexão
            SqlConnection connection = new SqlConnection();


            //Irei definir a string de conexão
            //informando os dados do banco
            //Host: Nome_Maquina/IP
            //DataBase: Nome_Banco
            //Autenticação: Usuario e Senha/Windows
            connection.ConnectionString =
                "Data Source=LUCAS-NOTE/SQLEXPRESS;" + //Nome do servidor
                "Initial Catalog=CRUDMVC;" + //Nome do banco
                "Integrated Security=SSPI;"; //Autenticação pelo Windows
                                             //Conexão com usuario e senha
                                             //"User ID=sa;" +
                                             //"Password=123456;"

            //Abriar a conexão com o banco
            connection.Open();
            //Retornar a conexão aberta
            return connection;
        }

        //Méto publico para execução de comandos
        //de manipulação (Insert, Update, Delete)
        //Retornar a quantidade de linhas afetadas
        public int ExecuteSQL(SqlCommand command)
        {
            //Recuperar a conexão com o banco
            command.Connection = GetConnection();
            //Executar o comando e retornar o resultado
            return command.ExecuteNonQuery();
        }
    }
}
