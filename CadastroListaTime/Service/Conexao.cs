using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TimeDeFutebol
{
    public class MySqlConnectionManager
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public string LastError { get; private set; }



        //contrutor
        public MySqlConnectionManager()
        {
            Initialize();
        }
        //parametros
        private void Initialize()
        {
            server = "localhost";        // Nome do servidor MySQL
            database = "times117";  // Nome do banco de dados
            uid = "root";             // Nome de usuário do MySQL
            password = "1234";          // Senha do MySQL

            string connectionString = $"SERVER={server};" +
                $"DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }
        //abrir conexão
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                LastError = ex.Message;
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                LastError = ex.Message;
                return false;
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}
