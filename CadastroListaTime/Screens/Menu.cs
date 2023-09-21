using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroListaTime
{
    public partial class Menu : Form
    {
        private ArrayList ListaEquipe = new ArrayList();
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Time equipeInstance = new Time();
            List<Time> ListaEquipe = equipeInstance.ListaEquipe();

            foreach (Time equipe in ListaEquipe)
            {
                cmbcadastrados.Items.Add(equipe.Nome);
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            string time = txttime.Text;

            if (string.IsNullOrWhiteSpace(time))
            {
                MessageBox.Show("O campo 'nome do time' não pode estar vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
              Time equipe = new Time();//chamar classe
                equipe.Nome = txttime.Text;//pego as propriedades
                equipe.Salvar();//chamo metodo salvar
                ListaEquipe.Add( equipe );
                UpdateTimesDisplay();

            }
        }
        private void UpdateTimesDisplay()
        {
            cmbcadastrados.Items.Clear();
            Time equipeInstance = new Time();
            //vai buscar no banco
            List<Time>ListaEquipe = equipeInstance.ListaEquipe();

            foreach (Time equipe in ListaEquipe) 
            {
                cmbcadastrados.Items.Add(equipe.Nome);
            }
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            cmbcadastrados.Items.Clear();
            txtexibir.Text = "";

            Time equipeInstance = new Time();
            List<Time> ListaEquipe = equipeInstance.ListaEquipe();

            foreach (Time equipe in ListaEquipe)
            {
                cmbcadastrados.Items.Add(equipe.Nome);
                txtexibir.Text += equipe.Nome + Environment.NewLine;
            }
        }

        private void txtexibir_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
          if(cmbcadastrados.SelectedIndex>=0)
            {
                Time listaEquipe = new Time();
                List<Time>ListaEquipe = listaEquipe.ListaEquipe();
                int selectedIndex = cmbcadastrados.SelectedIndex;
                if(selectedIndex < ListaEquipe.Count)
                {
                    //obtem o idtime selecionado
                    int idtime = ListaEquipe[selectedIndex].IdnomeTime;
                    
                    listaEquipe.IdnomeTime = idtime;
                    listaEquipe.Deletar();
                    listaEquipe.ListaEquipe().RemoveAt(selectedIndex);
                    UpdateTimesDisplay();

                }
            }

        }
    }
}
