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
    public partial class AdminForm : Form
    {
        IGestorUtilizadores gestor;
       
        public string Nome;
        public string Nif;
        public string User;
        public string Pass;
        public string Admin;

        public AdminForm()
        {
            InitializeComponent();
        }
        
        //mostra dados do utilizador
        public AdminForm(string nome, string nif, string user, string pass)
        {
            InitializeComponent();
            this.Nome = nome;
            this.Nif = nif;
            this.User = user;
            this.Pass = pass;

            txtAdminNome.Text = Nome;
            txtAdminNif.Text = Nif;
            txtAdminUser.Text = User;
            txtAdminPass.Text = Pass;

            lblAdminName.Text = Nome;

            ///////////////////////////////
            // Listar Utilizadores Query //
            ///////////////////////////////
            ListaUtilizadores();
        }

       
        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();            
        }

        private void btnAdicionaUtilizador_Click(object sender, EventArgs e)
        {
            string nome = txtAddNome.Text;
            string nif = txtAddNif.Text;
            string user = txtAddUser.Text;
            string pass = txtAddPassword.Text;
            bool isAdmin = chBoxIsAdmin.Checked;

            GestorUtilizadores gestor = new GestorUtilizadores();
            gestor.InsereUtilizador(nome, nif, user, pass, isAdmin);

            DataTable table = new DataTable();
        }

        private void ListaUtilizadores()
        {
            GestorUtilizadores gestor = new GestorUtilizadores();
            string conn = gestor.sqlString();
            SqlConnection connection = new SqlConnection((@conn));

            SqlCommand query = new SqlCommand("ListUsers", connection);
            query.CommandType = System.Data.CommandType.StoredProcedure;

            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query);
            DataTable table = new DataTable();
            adapter.Fill(table);
            usersDataGridView.DataSource = table;
            connection.Close();
        }

        private void btnAdminAtualizaPass_Click(object sender, EventArgs e)
        {
            string nif = txtAdminNif.Text;
            string Password = txtAdminPass.Text;

            GestorUtilizadores gestor = new GestorUtilizadores();
            gestor.AtualizaPassword(int.Parse(nif), Password);
        }

        private void usersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usersDataGridView.CurrentRow.Selected = true;
            txtAlterarNome.Text = usersDataGridView.Rows[e.RowIndex].Cells["Nome"].FormattedValue.ToString();
            txtAlterarNif.Text = usersDataGridView.Rows[e.RowIndex].Cells["Nif"].FormattedValue.ToString();
            txtAlterarUser.Text = usersDataGridView.Rows[e.RowIndex].Cells["NomeUtilizador"].FormattedValue.ToString();
            txtAlterarPassword.Text = usersDataGridView.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();
            chBoxAlterarIsAdmin.Checked = bool.Parse(usersDataGridView.Rows[e.RowIndex].Cells["Admin"].FormattedValue.ToString());
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            string nome = txtAlterarNome.Text;
            int nif = int.Parse(txtAlterarNif.Text);
            string user = txtAlterarUser.Text;
            string pass = txtAlterarPassword.Text;
            bool isAdmin = chBoxAlterarIsAdmin.Checked;

            GestorUtilizadores gestor = new GestorUtilizadores();
            gestor.AtualizaDados(nif, nome, user, pass, isAdmin);
        }

        private void btnEliminaUtilizador_Click(object sender, EventArgs e)
        {
            int nif = int.Parse(txtAlterarNif.Text);
            
            GestorUtilizadores gestor = new GestorUtilizadores();
            gestor.EliminaUtilizador(nif);
        }
    }
}
