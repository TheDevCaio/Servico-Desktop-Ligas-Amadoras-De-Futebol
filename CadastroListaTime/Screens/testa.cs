using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeDeFutebol;

namespace CadastroListaTime
{
    public partial class testa : Form
    {
        public testa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnectionManager connectionManager =
               new MySqlConnectionManager();
            if (connectionManager.OpenConnection())
            {
                MessageBox.Show("ok");
                connectionManager.CloseConnection();
            }
            else
            {
                MessageBox.Show("Falha na conexão. Detalhes do erro: " + connectionManager.LastError);
            }
        }
    }
}
