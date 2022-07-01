using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    abstract class Utilizador
    {
        protected string name;
        protected int nif;
        protected string username;
        protected string password;
        protected bool isAdmin;

        public Utilizador(string name,int nif, string username, string password, bool isAdmin)
        {
            this.name = name;
            this.nif = nif;
            this.username = username;
            this.password = password;
            this.isAdmin = isAdmin;
        }

        public string Name { get; set; }
        public int Nif { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public override string ToString()
        {
            return name + " "+ nif + " " + username + " " + password + " " + isAdmin;
        }

        public abstract SqlCommand ComandoAtualizarPassword();
       
    }
}
