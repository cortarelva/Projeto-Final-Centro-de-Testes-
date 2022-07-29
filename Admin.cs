using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Admin : Utilizador
    {
        public Admin(string name, int nif, string username, string password, bool isAdmin)
            : base(name, nif, username, password, isAdmin ? true : false)
        {
            this.isAdmin = isAdmin;
        }

        public override SqlCommand ComandoAtualizarPassword()
        {
            SqlCommand command = new SqlCommand("UPDATE Utilizador SET password = @password WHERE username = @username");
            command.Parameters.AddWithValue("@password", password);
            return command;
        }
    }
}
