using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TimeDeFutebol;

namespace CadastroListaTime
{
    public class Time
    {
        public string Nome { get; set; }
        public int IdnomeTime { get; set; }

        public void Salvar()
        {
            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO `nometime`(`nome`)VALUES(@nome)";
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Salvo com sucesso!");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Time> ListaEquipe()
        {
            //todas informaçoes da coluna criar lista
            List<Time> equipes = new List<Time>();
            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM nometime;";
                MySqlDataReader leitura = cmd.ExecuteReader();
                while (leitura.Read())
                {
                    Time equipe = new Time();
                    equipe.IdnomeTime = Convert.ToInt32(leitura["IdnomeTime"]);
                    equipe.Nome = leitura["Nome"].ToString();
                    equipes.Add(equipe);
                }
                leitura.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao conectar com o banco", ex.Message);
            }
            return equipes;
        }
        public void Deletar()
        {
            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM `nometime` WHERE idnomeTime = @IdnomeTime";
                cmd.Parameters.AddWithValue("@IdnomeTime", IdnomeTime);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Deletado com sucesso", "Apagado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
