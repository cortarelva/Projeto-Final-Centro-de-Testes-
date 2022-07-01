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
    public partial class LoginForm : Form
    {
        IGestorUtilizadores gestor;

        Form frm1 = null;
        
        public LoginForm(Form form1)
        {
            InitializeComponent();
            frm1 = form1;
        }
       


        private void lblCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnLoginForm_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;


            GestorUtilizadores gestor = new GestorUtilizadores();
            gestor.CarregaUtilizador(username, password);


            string[] respArr = gestor.CarregaUtilizador(username, password).Split(',');

            if (respArr.Length < 5)
            {
                lblWarning.Text = "Utilizador ou password inválidos";
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                string nome = respArr[0].ToString();
                string nif = respArr[1].ToString();
                string user = respArr[2].ToString();
                string pass = respArr[3].ToString();
                bool admin = bool.Parse(respArr[4]);

                if (admin != true)
                {
                    AlunoForm alunoForm = new AlunoForm(nome, nif, user, pass);
                    alunoForm.MdiParent = frm1;
                    alunoForm.Show();
                }
                else
                {
                    AdminForm adminForm = new AdminForm(nome, nif, user, pass);
                    adminForm.MdiParent = frm1;
                    adminForm.Show();
                }
            }
        }

        
        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
               
                txtPassword.PasswordChar = '\0';
            }
            else if (txtPassword.PasswordChar == '\0')
            {
                
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            lblWarning.Text = "";
        }
    }
}
