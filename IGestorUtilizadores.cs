using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    interface IGestorUtilizadores
    {
        string CarregaUtilizador(string username, string password);        
        void InsereUtilizador(string nome, string nif, string user, string pass,bool isAdmin);
        void AtualizaPassword(int nif, string password);
        string sqlString();
        void AtualizaDados(int nif, string nome, string user, string pass, bool isAdmin);
        void EliminaUtilizador(int nif);
    }
}
