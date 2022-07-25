using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class AlunoForm : Form
    {
        //IGestorUtilizadores gestor;
        
        public string Nome;
        public string Nif;
        public string User;
        public string Pass;
        
        
        public AlunoForm()
        {
            InitializeComponent();
        }


        public AlunoForm(string nome, string nif, string user, string pass)
        {
            InitializeComponent();
            
            this.Nome = nome;
            this.Nif = nif;
            this.User = user;
            this.Pass = pass;

            carregaDadosUtilizador( nome, nif, user, pass);
            ListaCertificacoes(nif);
            selecionaExame(); 
        }

       private void carregaDadosUtilizador(string nome, string nif, string user, string pass)
        {
            txtUserNome.Text = Nome;
            txtNif.Text = Nif;
            txtUser.Text = User;
            txtPass.Text = Pass;

            lblUserName.Text = "Está logado como: " + Nome;
        }
        
        public void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(); 
        }
        
        private void btnAlunoAtualizaPass_Click(object sender, EventArgs e)
        {
            string nif = txtNif.Text;
            string Password = txtPass.Text;

            GestorUtilizadores gestor = new GestorUtilizadores();
            gestor.AtualizaPassword(int.Parse(nif), Password);

        }
        
       private void selecionaExame()
        {
            GestorExames gestor = new GestorExames();
            string conn = gestor.sqlString();
            SqlConnection connection = new SqlConnection(@conn);

            SqlCommand command = new SqlCommand("SelectExame", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                cmbSelectExame.Items.Add(reader.GetValue(0).ToString());
            }
            connection.Close();  
        }

        private void btnExameStart_Click(object sender, EventArgs e)
        {
            try
            {
                string exame = cmbSelectExame.SelectedItem.ToString();
                string nif = txtNif.Text;
                ExameForm exameForm = new ExameForm(exame, nif);
                exameForm.Show();
            }
            catch
            {
                MessageBox.Show("Deve selecionar um exame primeiro");
            }
        }  
        private void ListaCertificacoes(string nif)
        {
            GestorUtilizadores gestor = new GestorUtilizadores();
            string conn = gestor.sqlString();
            SqlConnection connection = new SqlConnection((@conn));

            SqlCommand command = new SqlCommand("Select Exame, Nota, Data from Notas where nif =" + nif, connection);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            certificacoesDataGridView.DataSource = table;
            connection.Close();
        }
    }   
}
