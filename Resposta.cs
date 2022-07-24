using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    
    public class Respostas
    {
        //IGestorExames gestor;

        public string nif;
        public string numPergunta;
        public string resposta;
        public string exame;


        public Respostas(string nif, string numPergunta, string resposta, string exame)
        {
            this.nif = nif;
            this.numPergunta = numPergunta;
            this.resposta = resposta;
            this.exame = exame;
        }

        public override string ToString()
        {
            return (nif +" "+ numPergunta +" "+ resposta +" "+  exame + "\n"); 
        }




    }
}
