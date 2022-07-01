namespace ProjetoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnExit;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Button btnLoginWindow;
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnExit = new System.Windows.Forms.Button();
            btnLoginWindow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.SteelBlue;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnExit.ForeColor = System.Drawing.SystemColors.Desktop;
            btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            btnExit.Location = new System.Drawing.Point(0, 689);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(188, 65);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoginWindow
            // 
            btnLoginWindow.BackColor = System.Drawing.Color.SteelBlue;
            btnLoginWindow.FlatAppearance.BorderSize = 0;
            btnLoginWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoginWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLoginWindow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLoginWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginWindow.Image")));
            btnLoginWindow.Location = new System.Drawing.Point(1, 165);
            btnLoginWindow.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            btnLoginWindow.Name = "btnLoginWindow";
            btnLoginWindow.Size = new System.Drawing.Size(188, 65);
            btnLoginWindow.TabIndex = 1;
            btnLoginWindow.Text = "LOGIN";
            btnLoginWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnLoginWindow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLoginWindow.UseVisualStyleBackColor = false;
            btnLoginWindow.Click += new System.EventHandler(this.btnLoginWindow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(btnLoginWindow);
            this.panel1.Controls.Add(btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 754);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ProjetoFinal.Properties.Resources.testrus;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1211, 754);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

