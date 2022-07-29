using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SautinSoft.Document;
using System.Text.RegularExpressions;

namespace ProjetoFinal
{
    public partial class ExameForm : Form
    {
        int perguntaNum = 1;// inicializa as perguntas pelo numero 1
        string exame;
        string nif;
        
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
            lblExameNome.Text = exame;
        }

        public string Exame { get; set; }
        public string Nif { get; set; }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            selecionaResposta();
            contaTotalPerguntas();
             
            if (selecionaResposta().ToString() == carregaPergunta().ToString())
            {
                pontos += 3.33;
                respCertas += 1;
                //MessageBox.Show("Pontos: " + pontos+ "Resp certas: "+ respCertas);
            }
            limpaBotoesResposta();
            
            if(perguntaNum == contaTotalPerguntas())
            {
                lblNumPergunta.Text = " ";
                lblPergunta.Text = "Fim do exame";
                btnProxima.Enabled = false;
                btnVerResultado.Enabled = true;
                limpaBotoesResposta();
                lblRespostaA.Text = " ";
                lblRespostaB.Text = " ";
                lblRespostaC.Text = " ";
                lblRespostaD.Text = " ";
            }
            else
            {
                perguntaNum++;
                lblNumPergunta.Text = perguntaNum.ToString();
                carregaPergunta();
                btnAnterior.Enabled = true;
            }
        }

        private void btnVerResultado_Click(object sender, EventArgs e)
        {
            if (pontos > 66.60)
            {
                double percent = Math.Round(pontos);
                bool certificado =  true;
                DateTime date = DateTime.Today;
                insereNota(nif, exame, percent, certificado, date);
                emiteCertificado(nif, percent);
            }
            else
            {
                MessageBox.Show("Não conseguiu a nota minima para aprovação");
            } 
        }
        
        private void insereNota(string nif, string exame, double percent, bool certificado, DateTime date)
        { 
            GestorExames gestor = new GestorExames();
            string conn = gestor.sqlString();
            SqlConnection connection = new SqlConnection(@conn);
            
            SqlCommand command = new SqlCommand("Insert into Notas values(@Nif, @Exame, @Nota, @Certificado, @Data)", connection);
            command.Parameters.AddWithValue("@Nif", nif);
            command.Parameters.AddWithValue("@Exame", exame);
            command.Parameters.AddWithValue("@Nota", percent);
            command.Parameters.AddWithValue("@Certificado", certificado);
            command.Parameters.AddWithValue("@Data", date.ToString("d"));
            try
             {
                 connection.Open();
                 command.ExecuteNonQuery();
                 MessageBox.Show("Parabéns, concluiu o exame com " + respCertas + " resposta certas e uma percentagem de: " + percent + "%");
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Erro ao inserir nota: " + ex.Message);
             }
            finally
            {
                connection.Close();
            }
        }

        //metodo incompleto, não utilizar
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            perguntaNum--;
            carregaPergunta();
            lblNumPergunta.Text = perguntaNum.ToString();
            btnProxima.Enabled = true;  
            
            if(perguntaNum == 1)
            {
                perguntaNum = 1;
                lblNumPergunta.Text = perguntaNum.ToString();
                btnAnterior.Enabled = false;
            }
        }

        private string carregaPergunta()
        {
            string respostaCerta = "";
            GestorExames gestor = new GestorExames();
            string conn = gestor.sqlString();
            SqlConnection connection = new SqlConnection(@conn);

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

                respostaCerta = reader["RespostaCerta"].ToString();
            }
            connection.Close();
            return respostaCerta; 
        }
        
        private int contaTotalPerguntas()
        {
            int totalPerguntas = 0;
            GestorExames gestor = new GestorExames();
            string conn = gestor.sqlString();
            SqlConnection connection = new SqlConnection(@conn);
            SqlCommand count = new SqlCommand("Select Count(NumPergunta) from Perguntas where Exame = '" + exame + "'", connection);
            connection.Open();
            SqlDataReader countReader = count.ExecuteReader();
            lblNumPergunta.Text = perguntaNum.ToString();
            while (countReader.Read())
            {
                totalPerguntas = countReader.GetInt32(0);
            }
            connection.Close();
            return totalPerguntas;
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

        public void emiteCertificado(string nif, double percent)
        {
                GestorExames gestor = new GestorExames();
                string conn = gestor.sqlString();
                SqlConnection connection = new SqlConnection(@conn);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select Nome from Utilizador where Nif = @nif", connection);
                command.Parameters.AddWithValue("@nif", nif);
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    string nomeAluno = reader["Nome"].ToString();
                
                    string loadPath = @"C:\Development\Cet-programacao\C#\ProjetoFinal\documentos\certificate.docx";
                    // Load a document intoDocumentCore.
                    DocumentCore doc = DocumentCore.Load(loadPath);

                    try
                    {
                        Regex regexNome = new Regex(@"nome", RegexOptions.IgnoreCase);

                        foreach (ContentRange item in doc.Content.Find(regexNome).Reverse())
                        {
                            item.Replace(nomeAluno);
                        }
                        try
                        {
                            Regex regexExame = new Regex(@"curso", RegexOptions.IgnoreCase);

                            foreach (ContentRange item in doc.Content.Find(regexExame).Reverse())
                            {
                                item.Replace(exame);
                            }
                            try
                            {
                                Regex regexNota = new Regex(@"nota", RegexOptions.IgnoreCase);

                                foreach (ContentRange item in doc.Content.Find(regexNota).Reverse())
                                {
                                    item.Replace(percent.ToString());
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Erro ao substituir a nota");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erro ao substituir o exame");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao substituir o nome");
                    }

                    string savePath = @"C:\Users\Public\Desktop\Certificado " + exame + " - " + nomeAluno + ".pdf";
                    doc.Save(savePath, new PdfSaveOptions());

                    // Open the result for demonstration purposes.
                    //System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(loadPath) { UseShellExecute = true });
                     System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(savePath) { UseShellExecute = true });              
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao emitir certificado: " + ex.Message);
            }
            finally
            {
                connection.Close(); 
            }
        }
    }
}
