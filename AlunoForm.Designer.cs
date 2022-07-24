namespace ProjetoFinal
{
    partial class AlunoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlunoForm));
            this.tbPersonalData = new System.Windows.Forms.TabPage();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtUserNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlunoAtualizaPass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pBoxUser = new System.Windows.Forms.PictureBox();
            this.tbExamsData = new System.Windows.Forms.TabPage();
            this.certificacoesDataGridView = new System.Windows.Forms.DataGridView();
            this.lblCert = new System.Windows.Forms.Label();
            this.btnRegulamento = new System.Windows.Forms.Button();
            this.btnExameStart = new System.Windows.Forms.Button();
            this.lblSelecExame = new System.Windows.Forms.Label();
            this.cmbSelectExame = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.AlunotabControl = new System.Windows.Forms.TabControl();
            btnLogout = new System.Windows.Forms.Button();
            this.tbPersonalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUser)).BeginInit();
            this.tbExamsData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificacoesDataGridView)).BeginInit();
            this.AlunotabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            btnLogout.Location = new System.Drawing.Point(886, 0);
            btnLogout.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(130, 49);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOGOUT";
            btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tbPersonalData
            // 
            this.tbPersonalData.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPersonalData.Controls.Add(this.txtNif);
            this.tbPersonalData.Controls.Add(this.txtPass);
            this.tbPersonalData.Controls.Add(this.txtUser);
            this.tbPersonalData.Controls.Add(this.txtUserNome);
            this.tbPersonalData.Controls.Add(this.label4);
            this.tbPersonalData.Controls.Add(this.btnAlunoAtualizaPass);
            this.tbPersonalData.Controls.Add(this.label3);
            this.tbPersonalData.Controls.Add(this.label2);
            this.tbPersonalData.Controls.Add(this.label1);
            this.tbPersonalData.Controls.Add(this.pBoxUser);
            this.tbPersonalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonalData.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tbPersonalData.Location = new System.Drawing.Point(4, 30);
            this.tbPersonalData.Name = "tbPersonalData";
            this.tbPersonalData.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonalData.Size = new System.Drawing.Size(1016, 718);
            this.tbPersonalData.TabIndex = 1;
            this.tbPersonalData.Text = "Dados Pessoais";
            // 
            // txtNif
            // 
            this.txtNif.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNif.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNif.Location = new System.Drawing.Point(411, 118);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(170, 20);
            this.txtNif.TabIndex = 9;
            this.txtNif.Text = "...";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(411, 211);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(170, 27);
            this.txtPass.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(411, 163);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(170, 20);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "...";
            // 
            // txtUserNome
            // 
            this.txtUserNome.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUserNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNome.Location = new System.Drawing.Point(411, 74);
            this.txtUserNome.Name = "txtUserNome";
            this.txtUserNome.Size = new System.Drawing.Size(285, 20);
            this.txtUserNome.TabIndex = 1;
            this.txtUserNome.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nif";
            // 
            // btnAlunoAtualizaPass
            // 
            this.btnAlunoAtualizaPass.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAlunoAtualizaPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunoAtualizaPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunoAtualizaPass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAlunoAtualizaPass.Location = new System.Drawing.Point(621, 205);
            this.btnAlunoAtualizaPass.Name = "btnAlunoAtualizaPass";
            this.btnAlunoAtualizaPass.Size = new System.Drawing.Size(140, 36);
            this.btnAlunoAtualizaPass.TabIndex = 7;
            this.btnAlunoAtualizaPass.Text = "Salvar Nova Pass";
            this.btnAlunoAtualizaPass.UseVisualStyleBackColor = false;
            this.btnAlunoAtualizaPass.Click += new System.EventHandler(this.btnAlunoAtualizaPass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // pBoxUser
            // 
            this.pBoxUser.Image = global::ProjetoFinal.Properties.Resources.testImg;
            this.pBoxUser.InitialImage = global::ProjetoFinal.Properties.Resources.testImg;
            this.pBoxUser.Location = new System.Drawing.Point(107, 68);
            this.pBoxUser.Name = "pBoxUser";
            this.pBoxUser.Size = new System.Drawing.Size(151, 153);
            this.pBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxUser.TabIndex = 0;
            this.pBoxUser.TabStop = false;
            // 
            // tbExamsData
            // 
            this.tbExamsData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbExamsData.Controls.Add(this.certificacoesDataGridView);
            this.tbExamsData.Controls.Add(this.lblCert);
            this.tbExamsData.Controls.Add(this.btnRegulamento);
            this.tbExamsData.Controls.Add(this.btnExameStart);
            this.tbExamsData.Controls.Add(this.lblSelecExame);
            this.tbExamsData.Controls.Add(this.cmbSelectExame);
            this.tbExamsData.Controls.Add(this.lblUserName);
            this.tbExamsData.Controls.Add(btnLogout);
            this.tbExamsData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExamsData.Location = new System.Drawing.Point(4, 30);
            this.tbExamsData.Name = "tbExamsData";
            this.tbExamsData.Padding = new System.Windows.Forms.Padding(3);
            this.tbExamsData.Size = new System.Drawing.Size(1016, 718);
            this.tbExamsData.TabIndex = 0;
            this.tbExamsData.Text = "Dados Exames";
            // 
            // certificacoesDataGridView
            // 
            this.certificacoesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.certificacoesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.certificacoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.certificacoesDataGridView.Location = new System.Drawing.Point(482, 133);
            this.certificacoesDataGridView.Name = "certificacoesDataGridView";
            this.certificacoesDataGridView.Size = new System.Drawing.Size(436, 434);
            this.certificacoesDataGridView.TabIndex = 12;
            // 
            // lblCert
            // 
            this.lblCert.AutoSize = true;
            this.lblCert.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCert.ForeColor = System.Drawing.Color.Teal;
            this.lblCert.Location = new System.Drawing.Point(475, 93);
            this.lblCert.Name = "lblCert";
            this.lblCert.Size = new System.Drawing.Size(340, 37);
            this.lblCert.TabIndex = 11;
            this.lblCert.Text = "As Minhas Certificações ";
            // 
            // btnRegulamento
            // 
            this.btnRegulamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegulamento.Location = new System.Drawing.Point(27, 547);
            this.btnRegulamento.Name = "btnRegulamento";
            this.btnRegulamento.Size = new System.Drawing.Size(242, 71);
            this.btnRegulamento.TabIndex = 10;
            this.btnRegulamento.Text = "Regulamento";
            this.btnRegulamento.UseVisualStyleBackColor = true;
            // 
            // btnExameStart
            // 
            this.btnExameStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExameStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExameStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExameStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExameStart.Location = new System.Drawing.Point(28, 151);
            this.btnExameStart.Name = "btnExameStart";
            this.btnExameStart.Size = new System.Drawing.Size(241, 63);
            this.btnExameStart.TabIndex = 9;
            this.btnExameStart.Text = "INICIAR";
            this.btnExameStart.UseVisualStyleBackColor = false;
            this.btnExameStart.Click += new System.EventHandler(this.btnExameStart_Click);
            // 
            // lblSelecExame
            // 
            this.lblSelecExame.AutoSize = true;
            this.lblSelecExame.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecExame.ForeColor = System.Drawing.Color.Teal;
            this.lblSelecExame.Location = new System.Drawing.Point(22, 51);
            this.lblSelecExame.Name = "lblSelecExame";
            this.lblSelecExame.Size = new System.Drawing.Size(248, 37);
            this.lblSelecExame.TabIndex = 7;
            this.lblSelecExame.Text = "Selecionar Exame";
            // 
            // cmbSelectExame
            // 
            this.cmbSelectExame.FormattingEnabled = true;
            this.cmbSelectExame.Location = new System.Drawing.Point(28, 93);
            this.cmbSelectExame.Name = "cmbSelectExame";
            this.cmbSelectExame.Size = new System.Drawing.Size(242, 29);
            this.cmbSelectExame.TabIndex = 6;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(24, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(27, 25);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "...";
            // 
            // AlunotabControl
            // 
            this.AlunotabControl.Controls.Add(this.tbExamsData);
            this.AlunotabControl.Controls.Add(this.tbPersonalData);
            this.AlunotabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlunotabControl.Location = new System.Drawing.Point(-2, 0);
            this.AlunotabControl.Name = "AlunotabControl";
            this.AlunotabControl.SelectedIndex = 0;
            this.AlunotabControl.Size = new System.Drawing.Size(1024, 752);
            this.AlunotabControl.TabIndex = 0;
            // 
            // AlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 749);
            this.Controls.Add(this.AlunotabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlunoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AlunoForm";
            this.tbPersonalData.ResumeLayout(false);
            this.tbPersonalData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUser)).EndInit();
            this.tbExamsData.ResumeLayout(false);
            this.tbExamsData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificacoesDataGridView)).EndInit();
            this.AlunotabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbPersonalData;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtUserNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlunoAtualizaPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBoxUser;
        private System.Windows.Forms.TabPage tbExamsData;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TabControl AlunotabControl;
        private System.Windows.Forms.Label lblSelecExame;
        private System.Windows.Forms.ComboBox cmbSelectExame;
        private System.Windows.Forms.Button btnExameStart;
        private System.Windows.Forms.Label lblCert;
        private System.Windows.Forms.Button btnRegulamento;
        private System.Windows.Forms.DataGridView certificacoesDataGridView;
    }
}