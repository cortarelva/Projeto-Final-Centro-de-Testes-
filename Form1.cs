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
        public static int op = 1;
        public Form1()
        {
            InitializeComponent();
        }

        public void EnviaForm1()
        {
            Form form1 = this; 
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
            if(op == 1)
            {
                LoginForm login = new LoginForm(this);
                login.MdiParent = this;
                login.Show();
                op = 0;
            }
            else
            {
                MessageBox.Show("Tem de fazer logout primeiro");
            }
        }
    }
}
