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
    public partial class ExameForm : Form
    {
        IGestorExames gestor;

        int perguntaNum = 1;// inicializa as perguntas pelo numero 1
        protected string exame;
        protected string nif;
        double pontos = 0.00;
        int respCertas = 0;
        
        public ExameForm()
        {
            InitializeComponent();
        }

        public ExameForm(string exame, string nif)
        {
            InitializeComponent();
            this.exame = exame;
            this.nif = nif;
            carregaPergunta();
            lblNumPergunta.Text = perguntaNum.ToString();
        }


        public string Exame { get; set; }
        public string Nif { get; }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            
            perguntaNum++;
            carregaPergunta();
            contaTotalPerguntas();
            selecionaResposta();
            btnAnterior.Enabled = true;

            label1.Text = selecionaResposta(); //resposta a guardar
            label2.Text = carregaPergunta().ToString(); //retorna a letra da resposta correta
            label3.Text = nif;//nif do aluno que esta a fazer o exame
            label4.Text = exame;//exame a que pertence a resposta


            if (selecionaResposta().ToString() == carregaPergunta().ToString())
            {
                pontos += 3.33;
                respCertas += 1;
                MessageBox.Show("Pontos: " + pontos);
            }
            limpaBotoesResposta();
        }

        private void btnVerResultado_Click(object sender, EventArgs e)
        {
            if(pontos >= 6.66)
            {
                MessageBox.Show("Parabéns, você concluiu o exame com " + respCertas + " resposta certas!");
            }
            else
            {
                MessageBox.Show("Você não concluiu o exame com " + respCertas + " resposta certas!");
            }
            
            
        }



        private void btnAnterior_Click(object sender, EventArgs e)
        {
                perguntaNum--;
                carregaPergunta();
                lblNumPergunta.Text = perguntaNum.ToString();
                btnProxima.Enabled = true;  
            
             if(perguntaNum == 1)
            {
                perguntaNum = 1;
                btnAnterior.Enabled = false;
            }
            limpaBotoesResposta();
        }

        private string carregaPergunta()
        {
            //int numPerguntaParaGuardar = 1;
            string respostaCerta = "";
            GestorExames gestor = new GestorExames();
            string conn = gestor.sqlString();
            SqlConnection connection = new SqlConnection((@conn));

            SqlCommand command = new SqlCommand("Select * from Perguntas where Exame = '" + exame + "' And NumPergunta = " + perguntaNum, connection);
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            

            while (reader.Read())
            {
                lblPergunta.Text = reader["Pergunta"].ToString();
                lblRespostaA.Text = reader["RespostaA"].ToString();
                lblRespostaB.Text = reader["RespostaB"].ToString();
                lblRespostaC.Text = reader["RespostaC"].ToString();
                lblRespostaD.Text = reader["RespostaD"].ToString();

                //numPerguntaParaGuardar = Convert.ToInt32(reader["NumPergunta"]) - 1;
                respostaCerta = reader["RespostaCerta"].ToString();
            }
            return respostaCerta;
        }
        
        private void contaTotalPerguntas()
        {
            GestorExames gestor = new GestorExames();
            string conn = gestor.sqlString();
            SqlConnection connection = new SqlConnection((@conn));

            SqlCommand count = new SqlCommand("Select Count(Id) from Perguntas where Exame = '" + exame + "'", connection);
            connection.Open();
            SqlDataReader countReader = count.ExecuteReader();

            lblNumPergunta.Text = perguntaNum.ToString();
            while (countReader.Read())
            {
                if (perguntaNum == countReader.GetInt32(0))
                {
                    btnProxima.Enabled = false;
                }
            }
        }
        
        private string selecionaResposta()
        {
            string resp = "";

            if (rbtnRespostaA.Checked)
            {
                resp = "a";
            }
            else if (rbtnRespostaB.Checked)
            {
                resp = "b";
            }
            else if (rbtnRespostaC.Checked)
            {
                resp = "c";
            }
            else if (rbtnRespostaD.Checked)
            {
                resp = "d";
            }
            return resp;
        }
        
        private void limpaBotoesResposta()
        {
            rbtnRespostaA.Checked = false;
            rbtnRespostaB.Checked = false;
            rbtnRespostaC.Checked = false;
            rbtnRespostaD.Checked = false;
        }

        
    }
}
