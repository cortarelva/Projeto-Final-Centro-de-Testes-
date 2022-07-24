using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal interface IGestorExames
    {
        string sqlString();
        void InserirPergunta(string pergunta,string respostaA,string respostaB,string respostaC,string respostaD,string respostaCorreta, string exame, int numPergunta);
    }
}
