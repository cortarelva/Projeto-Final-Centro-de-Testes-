using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    internal class GestorExames : IGestorExames
    {
        SqlConnection connection;

        public GestorExames()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Development\Cet-programacao\C#\ProjetoFinal\CentroDeTestes.mdf;Integrated Security=True");
        }

        public string sqlString()
        {
            string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Development\\Cet-programacao\\C#\\ProjetoFinal\\CentroDeTestes.mdf;Integrated Security=True";
            return connection;
        }

        public void InserirPergunta(string pergunta, string respostaA, string respostaB, string respostaC, string respostaD, string respostaCorreta, string exame, int numPergunta)
        {
            SqlCommand command = new SqlCommand("InsertPergunta", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Pergunta", System.Data.SqlDbType.VarChar, 200).Value = pergunta;
            command.Parameters.Add("@RespostaA", System.Data.SqlDbType.VarChar, 200).Value = respostaA;
            command.Parameters.Add("@RespostaB", System.Data.SqlDbType.VarChar, 200).Value = respostaB;
            command.Parameters.Add("@RespostaC", System.Data.SqlDbType.VarChar, 200).Value = respostaC;
            command.Parameters.Add("@RespostaD", System.Data.SqlDbType.VarChar, 200).Value = respostaD;
            command.Parameters.Add("@RespostaCerta", System.Data.SqlDbType.VarChar, 50).Value = respostaCorreta;
            command.Parameters.Add("@Exame", System.Data.SqlDbType.VarChar, 50).Value = exame;
            command.Parameters.Add("@numPergunta", System.Data.SqlDbType.Int).Value = numPergunta;
            connection.Open();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Pergunta inserida");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo correu mal!", ex.Message);
            }
            connection.Close();
        }
    }
}
