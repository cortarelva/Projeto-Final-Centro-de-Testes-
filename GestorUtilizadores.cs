using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    class GestorUtilizadores : IGestorUtilizadores
    {
        SqlConnection connection;
        
        public GestorUtilizadores()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Development\Cet-programacao\C#\ProjetoFinal\CentroDeTestes.mdf;Integrated Security=True");
        }
        
        public string sqlString()
        {
            string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Development\\Cet-programacao\\C#\\ProjetoFinal\\CentroDeTestes.mdf;Integrated Security=True";
            return connection;
        }
       
        public string CarregaUtilizador(string username ,string password)
        {
            string nome = "", nif="", user="", pass="", admin="", resposta ="";
            
            SqlCommand command = new SqlCommand("SelectUser", connection);
            
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 50).Value = username;
            command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 50).Value = password;
            connection.Open();

            SqlDataReader sqlDataReader = command.ExecuteReader();
            sqlDataReader.Read();

            if (sqlDataReader.HasRows)
            {
                nif = sqlDataReader["Nif"].ToString();
                nome = sqlDataReader["Nome"].ToString();
                user = sqlDataReader["NomeUtilizador"].ToString();
                pass = sqlDataReader["Password"].ToString();
                admin = sqlDataReader["Admin"].ToString();

                resposta = nome + "," + nif + "," + user + "," + pass + "," + admin;
            }
            else
            {
                resposta = "";
            }
            
            connection.Close();
            return resposta;
        }
        
        public void InsereUtilizador(string nome, string nif, string user, string pass,bool isAdmin)
        {
            
            SqlCommand command = new SqlCommand("InsertUser", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Nif", System.Data.SqlDbType.VarChar, 50).Value = nif;
            command.Parameters.Add("@Nome", System.Data.SqlDbType.VarChar, 50).Value = nome;
            command.Parameters.Add("@NomeUtilizador", System.Data.SqlDbType.VarChar, 50).Value = user;
            command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 50).Value = pass;
            command.Parameters.Add("@Admin", System.Data.SqlDbType.Bit).Value = isAdmin;
            
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Utilizador inserido com sucesso!");
            }
            catch
            {
                MessageBox.Show("Algo correu mal!");
            }  
        }
        
        public void AtualizaPassword(int nif, string password)
        {
            string message = "Alterar a Password?";
            string title = "Alterar Password";

            SqlCommand command = new SqlCommand("UpdatePassword", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Nif", System.Data.SqlDbType.VarChar, 50).Value = nif;
            command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 50).Value = password;

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Password atualizada com sucesso!");
                }
                catch
                {
                    MessageBox.Show("Algo correu mal!");
                }
            }
        }

        public void AtualizaDados(int nif, string nome, string user, string pass, bool isAdmin)
        {
            int numAdmin = 0;

            if (isAdmin == true)
            {
                numAdmin = 1;
            }
            else
            {
                numAdmin = 0;
            }
            
            string message = "Alterar os dados?";
            string title = "Alterar Dados";

            SqlCommand command = new SqlCommand("UpdateDados", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Nif", System.Data.SqlDbType.Int).Value = nif;
            command.Parameters.Add("@Nome", System.Data.SqlDbType.VarChar, 50).Value = nome;
            command.Parameters.Add("@Username", System.Data.SqlDbType.VarChar, 50).Value = user;
            command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 50).Value = pass;
            command.Parameters.Add("@Admin", System.Data.SqlDbType.Bit).Value = numAdmin;

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Dados atualizados com sucesso!");
                }
                catch
                {
                    MessageBox.Show("Algo correu mal!");
                }
            }
        }
        
        public void EliminaUtilizador(int nif)
        {
            string message = "Eliminar o utilizador?";
            string title = "Eliminar Utilizador";

            SqlCommand command = new SqlCommand("DeleteUser", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Nif", System.Data.SqlDbType.Int).Value = nif;

            MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Utilizador eliminado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Algo correu mal!");
            }
        }
    }
}
