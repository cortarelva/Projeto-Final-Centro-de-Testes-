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

       
    }
   
}
