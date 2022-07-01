namespace ProjetoFinal
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnLogout;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.examsTab = new System.Windows.Forms.TabPage();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.personalDataTab = new System.Windows.Forms.TabPage();
            this.txtAdminNif = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdminAtualizaPass = new System.Windows.Forms.Button();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminNome = new System.Windows.Forms.TextBox();
            this.userAdminTab = new System.Windows.Forms.TabPage();
            this.chBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnAdicionaUtilizador = new System.Windows.Forms.Button();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.txtAddUser = new System.Windows.Forms.TextBox();
            this.txtAddNif = new System.Windows.Forms.TextBox();
            this.txtAddNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listaUsersTab = new System.Windows.Forms.TabPage();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.txtAlterarPassword = new System.Windows.Forms.TextBox();
            this.txtAlterarNif = new System.Windows.Forms.TextBox();
            this.txtAlterarUser = new System.Windows.Forms.TextBox();
            this.txtAlterarNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.chBoxAlterarIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnEliminaUtilizador = new System.Windows.Forms.Button();
            this.pBoxUser = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            btnLogout = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.examsTab.SuspendLayout();
            this.personalDataTab.SuspendLayout();
            this.userAdminTab.SuspendLayout();
            this.listaUsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUser)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.examsTab);
            this.tabControl.Controls.Add(this.personalDataTab);
            this.tabControl.Controls.Add(this.userAdminTab);
            this.tabControl.Controls.Add(this.listaUsersTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1018, 751);
            this.tabControl.TabIndex = 0;
            // 
            // examsTab
            // 
            this.examsTab.BackColor = System.Drawing.Color.Silver;
            this.examsTab.Controls.Add(this.tabControl1);
            this.examsTab.Controls.Add(this.lblAdminName);
            this.examsTab.Controls.Add(btnLogout);
            this.examsTab.Location = new System.Drawing.Point(4, 30);
            this.examsTab.Name = "examsTab";
            this.examsTab.Padding = new System.Windows.Forms.Padding(3);
            this.examsTab.Size = new System.Drawing.Size(1010, 717);
            this.examsTab.TabIndex = 0;
            this.examsTab.Text = "Exams Data";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(37, 13);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(22, 21);
            this.lblAdminName.TabIndex = 6;
            this.lblAdminName.Text = "...";
            this.lblAdminName.UseWaitCursor = true;
            // 
            // personalDataTab
            // 
            this.personalDataTab.BackColor = System.Drawing.Color.Gainsboro;
            this.personalDataTab.Controls.Add(this.txtAdminNif);
            this.personalDataTab.Controls.Add(this.label4);
            this.personalDataTab.Controls.Add(this.btnAdminAtualizaPass);
            this.personalDataTab.Controls.Add(this.txtAdminPass);
            this.personalDataTab.Controls.Add(this.label3);
            this.personalDataTab.Controls.Add(this.txtAdminUser);
            this.personalDataTab.Controls.Add(this.label2);
            this.personalDataTab.Controls.Add(this.label1);
            this.personalDataTab.Controls.Add(this.txtAdminNome);
            this.personalDataTab.Controls.Add(this.pBoxUser);
            this.personalDataTab.Location = new System.Drawing.Point(4, 30);
            this.personalDataTab.Name = "personalDataTab";
            this.personalDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.personalDataTab.Size = new System.Drawing.Size(1010, 717);
            this.personalDataTab.TabIndex = 1;
            this.personalDataTab.Text = "Personal Data";
            // 
            // txtAdminNif
            // 
            this.txtAdminNif.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAdminNif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminNif.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminNif.Location = new System.Drawing.Point(470, 120);
            this.txtAdminNif.Name = "txtAdminNif";
            this.txtAdminNif.Size = new System.Drawing.Size(170, 20);
            this.txtAdminNif.TabIndex = 19;
            this.txtAdminNif.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nif";
            // 
            // btnAdminAtualizaPass
            // 
            this.btnAdminAtualizaPass.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdminAtualizaPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminAtualizaPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAtualizaPass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdminAtualizaPass.Location = new System.Drawing.Point(680, 207);
            this.btnAdminAtualizaPass.Name = "btnAdminAtualizaPass";
            this.btnAdminAtualizaPass.Size = new System.Drawing.Size(140, 36);
            this.btnAdminAtualizaPass.TabIndex = 17;
            this.btnAdminAtualizaPass.Text = "Salvar Nova Pass";
            this.btnAdminAtualizaPass.UseVisualStyleBackColor = false;
            this.btnAdminAtualizaPass.Click += new System.EventHandler(this.btnAdminAtualizaPass_Click);
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPass.Location = new System.Drawing.Point(470, 213);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.Size = new System.Drawing.Size(170, 27);
            this.txtAdminPass.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // txtAdminUser
            // 
            this.txtAdminUser.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAdminUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminUser.Location = new System.Drawing.Point(470, 165);
            this.txtAdminUser.Name = "txtAdminUser";
            this.txtAdminUser.Size = new System.Drawing.Size(170, 20);
            this.txtAdminUser.TabIndex = 14;
            this.txtAdminUser.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // txtAdminNome
            // 
            this.txtAdminNome.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAdminNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminNome.Location = new System.Drawing.Point(470, 76);
            this.txtAdminNome.Name = "txtAdminNome";
            this.txtAdminNome.Size = new System.Drawing.Size(285, 20);
            this.txtAdminNome.TabIndex = 11;
            this.txtAdminNome.Text = "...";
            // 
            // userAdminTab
            // 
            this.userAdminTab.BackColor = System.Drawing.Color.Gainsboro;
            this.userAdminTab.Controls.Add(this.chBoxIsAdmin);
            this.userAdminTab.Controls.Add(this.btnAdicionaUtilizador);
            this.userAdminTab.Controls.Add(this.txtAddPassword);
            this.userAdminTab.Controls.Add(this.txtAddUser);
            this.userAdminTab.Controls.Add(this.txtAddNif);
            this.userAdminTab.Controls.Add(this.txtAddNome);
            this.userAdminTab.Controls.Add(this.label5);
            this.userAdminTab.Controls.Add(this.label6);
            this.userAdminTab.Controls.Add(this.label7);
            this.userAdminTab.Controls.Add(this.label8);
            this.userAdminTab.Location = new System.Drawing.Point(4, 30);
            this.userAdminTab.Name = "userAdminTab";
            this.userAdminTab.Padding = new System.Windows.Forms.Padding(3);
            this.userAdminTab.Size = new System.Drawing.Size(1010, 717);
            this.userAdminTab.TabIndex = 2;
            this.userAdminTab.Text = "Inserir Novo Utilizador";
            // 
            // chBoxIsAdmin
            // 
            this.chBoxIsAdmin.AutoSize = true;
            this.chBoxIsAdmin.Location = new System.Drawing.Point(376, 280);
            this.chBoxIsAdmin.Name = "chBoxIsAdmin";
            this.chBoxIsAdmin.Size = new System.Drawing.Size(80, 25);
            this.chBoxIsAdmin.TabIndex = 29;
            this.chBoxIsAdmin.Text = "ADMIN";
            this.chBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAdicionaUtilizador
            // 
            this.btnAdicionaUtilizador.BackColor = System.Drawing.Color.Aqua;
            this.btnAdicionaUtilizador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionaUtilizador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionaUtilizador.Location = new System.Drawing.Point(376, 329);
            this.btnAdicionaUtilizador.Name = "btnAdicionaUtilizador";
            this.btnAdicionaUtilizador.Size = new System.Drawing.Size(369, 66);
            this.btnAdicionaUtilizador.TabIndex = 27;
            this.btnAdicionaUtilizador.Text = "Adicionar";
            this.btnAdicionaUtilizador.UseVisualStyleBackColor = false;
            this.btnAdicionaUtilizador.Click += new System.EventHandler(this.btnAdicionaUtilizador_Click);
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(376, 221);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(369, 29);
            this.txtAddPassword.TabIndex = 26;
            // 
            // txtAddUser
            // 
            this.txtAddUser.Location = new System.Drawing.Point(376, 173);
            this.txtAddUser.Name = "txtAddUser";
            this.txtAddUser.Size = new System.Drawing.Size(369, 29);
            this.txtAddUser.TabIndex = 25;
            // 
            // txtAddNif
            // 
            this.txtAddNif.Location = new System.Drawing.Point(376, 128);
            this.txtAddNif.Name = "txtAddNif";
            this.txtAddNif.Size = new System.Drawing.Size(369, 29);
            this.txtAddNif.TabIndex = 24;
            // 
            // txtAddNome
            // 
            this.txtAddNome.Location = new System.Drawing.Point(376, 81);
            this.txtAddNome.Name = "txtAddNome";
            this.txtAddNome.Size = new System.Drawing.Size(369, 29);
            this.txtAddNome.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nif";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(253, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nome";
            // 
            // listaUsersTab
            // 
            this.listaUsersTab.Controls.Add(this.label13);
            this.listaUsersTab.Controls.Add(this.btnEliminaUtilizador);
            this.listaUsersTab.Controls.Add(this.chBoxAlterarIsAdmin);
            this.listaUsersTab.Controls.Add(this.btnAlterarDados);
            this.listaUsersTab.Controls.Add(this.txtAlterarPassword);
            this.listaUsersTab.Controls.Add(this.txtAlterarNif);
            this.listaUsersTab.Controls.Add(this.txtAlterarUser);
            this.listaUsersTab.Controls.Add(this.txtAlterarNome);
            this.listaUsersTab.Controls.Add(this.label12);
            this.listaUsersTab.Controls.Add(this.label11);
            this.listaUsersTab.Controls.Add(this.label10);
            this.listaUsersTab.Controls.Add(this.label9);
            this.listaUsersTab.Controls.Add(this.usersDataGridView);
            this.listaUsersTab.Location = new System.Drawing.Point(4, 30);
            this.listaUsersTab.Name = "listaUsersTab";
            this.listaUsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.listaUsersTab.Size = new System.Drawing.Size(1010, 717);
            this.listaUsersTab.TabIndex = 3;
            this.listaUsersTab.Text = "Listar Utilizadores";
            this.listaUsersTab.UseVisualStyleBackColor = true;
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.BackColor = System.Drawing.Color.Aqua;
            this.btnAlterarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarDados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDados.Location = new System.Drawing.Point(37, 633);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(561, 74);
            this.btnAlterarDados.TabIndex = 11;
            this.btnAlterarDados.Text = "Guardar Alterações";
            this.btnAlterarDados.UseVisualStyleBackColor = false;
            this.btnAlterarDados.Click += new System.EventHandler(this.btnAlterarDados_Click);
            // 
            // txtAlterarPassword
            // 
            this.txtAlterarPassword.Location = new System.Drawing.Point(409, 565);
            this.txtAlterarPassword.Name = "txtAlterarPassword";
            this.txtAlterarPassword.Size = new System.Drawing.Size(189, 29);
            this.txtAlterarPassword.TabIndex = 10;
            // 
            // txtAlterarNif
            // 
            this.txtAlterarNif.Enabled = false;
            this.txtAlterarNif.Location = new System.Drawing.Point(409, 485);
            this.txtAlterarNif.Name = "txtAlterarNif";
            this.txtAlterarNif.Size = new System.Drawing.Size(189, 29);
            this.txtAlterarNif.TabIndex = 9;
            // 
            // txtAlterarUser
            // 
            this.txtAlterarUser.Location = new System.Drawing.Point(37, 565);
            this.txtAlterarUser.Name = "txtAlterarUser";
            this.txtAlterarUser.Size = new System.Drawing.Size(299, 29);
            this.txtAlterarUser.TabIndex = 8;
            // 
            // txtAlterarNome
            // 
            this.txtAlterarNome.Location = new System.Drawing.Point(37, 485);
            this.txtAlterarNome.Name = "txtAlterarNome";
            this.txtAlterarNome.Size = new System.Drawing.Size(299, 29);
            this.txtAlterarNome.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 536);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 461);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nif";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 541);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nome Utilizador";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nome";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AllowUserToResizeColumns = false;
            this.usersDataGridView.AllowUserToResizeRows = false;
            this.usersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.usersDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.usersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.usersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(1004, 395);
            this.usersDataGridView.TabIndex = 2;
            this.usersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGridView_CellClick);
            // 
            // chBoxAlterarIsAdmin
            // 
            this.chBoxAlterarIsAdmin.AutoSize = true;
            this.chBoxAlterarIsAdmin.Location = new System.Drawing.Point(37, 602);
            this.chBoxAlterarIsAdmin.Name = "chBoxAlterarIsAdmin";
            this.chBoxAlterarIsAdmin.Size = new System.Drawing.Size(75, 25);
            this.chBoxAlterarIsAdmin.TabIndex = 13;
            this.chBoxAlterarIsAdmin.Text = "Admin";
            this.chBoxAlterarIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnEliminaUtilizador
            // 
            this.btnEliminaUtilizador.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminaUtilizador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaUtilizador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaUtilizador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminaUtilizador.Location = new System.Drawing.Point(708, 630);
            this.btnEliminaUtilizador.Name = "btnEliminaUtilizador";
            this.btnEliminaUtilizador.Size = new System.Drawing.Size(232, 77);
            this.btnEliminaUtilizador.TabIndex = 14;
            this.btnEliminaUtilizador.Text = "Eliminar Utilizador";
            this.btnEliminaUtilizador.UseVisualStyleBackColor = false;
            this.btnEliminaUtilizador.Click += new System.EventHandler(this.btnEliminaUtilizador_Click);
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            btnLogout.Location = new System.Drawing.Point(880, 0);
            btnLogout.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(130, 49);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "LOGOUT";
            btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.UseWaitCursor = true;
            btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pBoxUser
            // 
            this.pBoxUser.Image = global::ProjetoFinal.Properties.Resources.testImg;
            this.pBoxUser.InitialImage = global::ProjetoFinal.Properties.Resources.testImg;
            this.pBoxUser.Location = new System.Drawing.Point(166, 70);
            this.pBoxUser.Name = "pBoxUser";
            this.pBoxUser.Size = new System.Drawing.Size(151, 153);
            this.pBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxUser.TabIndex = 10;
            this.pBoxUser.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 641);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 30);
            this.label13.TabIndex = 15;
            this.label13.Text = "ALTERAR DADOS";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 749);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AdminForm";
            this.tabControl.ResumeLayout(false);
            this.examsTab.ResumeLayout(false);
            this.examsTab.PerformLayout();
            this.personalDataTab.ResumeLayout(false);
            this.personalDataTab.PerformLayout();
            this.userAdminTab.ResumeLayout(false);
            this.userAdminTab.PerformLayout();
            this.listaUsersTab.ResumeLayout(false);
            this.listaUsersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUser)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage examsTab;
        private System.Windows.Forms.TabPage personalDataTab;
        private System.Windows.Forms.TextBox txtAdminNif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdminAtualizaPass;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdminNome;
        private System.Windows.Forms.PictureBox pBoxUser;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.TabPage userAdminTab;
        private System.Windows.Forms.CheckBox chBoxIsAdmin;
        private System.Windows.Forms.Button btnAdicionaUtilizador;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.TextBox txtAddUser;
        private System.Windows.Forms.TextBox txtAddNif;
        private System.Windows.Forms.TextBox txtAddNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage listaUsersTab;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.TextBox txtAlterarPassword;
        private System.Windows.Forms.TextBox txtAlterarNif;
        private System.Windows.Forms.TextBox txtAlterarUser;
        private System.Windows.Forms.TextBox txtAlterarNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chBoxAlterarIsAdmin;
        private System.Windows.Forms.Button btnEliminaUtilizador;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label13;
    }
}