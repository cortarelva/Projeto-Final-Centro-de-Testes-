using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void EnviaForm1()
        {
            Form form1 = this; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Tem certeza que quer terminar o programa?";
            string title = "Terminar Aplicação";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void btnLoginWindow_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(this);
            login.MdiParent = this;
            login.Show();
        }

       
    }
}
