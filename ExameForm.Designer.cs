namespace ProjetoFinal
{
    partial class ExameForm
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
            this.lblExit = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.lblRespostaA = new System.Windows.Forms.Label();
            this.lblRespostaB = new System.Windows.Forms.Label();
            this.lblRespostaC = new System.Windows.Forms.Label();
            this.lblRespostaD = new System.Windows.Forms.Label();
            this.btnProxima = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblNumPergunta = new System.Windows.Forms.Label();
            this.rbtnRespostaA = new System.Windows.Forms.RadioButton();
            this.rbtnRespostaB = new System.Windows.Forms.RadioButton();
            this.rbtnRespostaC = new System.Windows.Forms.RadioButton();
            this.rbtnRespostaD = new System.Windows.Forms.RadioButton();
            this.btnVerResultado = new System.Windows.Forms.Button();
            this.lblExameNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.AliceBlue;
            this.lblExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Crimson;
            this.lblExit.Location = new System.Drawing.Point(1158, 22);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(47, 13);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "EXIT ->";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(174, 256);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(111, 32);
            this.lblPergunta.TabIndex = 1;
            this.lblPergunta.Text = "pergunta";
            // 
            // lblRespostaA
            // 
            this.lblRespostaA.AutoSize = true;
            this.lblRespostaA.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespostaA.Location = new System.Drawing.Point(424, 353);
            this.lblRespostaA.Margin = new System.Windows.Forms.Padding(3);
            this.lblRespostaA.Name = "lblRespostaA";
            this.lblRespostaA.Size = new System.Drawing.Size(116, 32);
            this.lblRespostaA.TabIndex = 2;
            this.lblRespostaA.Text = "resposta1";
            this.lblRespostaA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRespostaB
            // 
            this.lblRespostaB.AutoSize = true;
            this.lblRespostaB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespostaB.Location = new System.Drawing.Point(424, 396);
            this.lblRespostaB.Margin = new System.Windows.Forms.Padding(3);
            this.lblRespostaB.Name = "lblRespostaB";
            this.lblRespostaB.Size = new System.Drawing.Size(116, 32);
            this.lblRespostaB.TabIndex = 3;
            this.lblRespostaB.Text = "resposta2";
            this.lblRespostaB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRespostaC
            // 
            this.lblRespostaC.AutoSize = true;
            this.lblRespostaC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespostaC.Location = new System.Drawing.Point(424, 439);
            this.lblRespostaC.Margin = new System.Windows.Forms.Padding(3);
            this.lblRespostaC.Name = "lblRespostaC";
            this.lblRespostaC.Size = new System.Drawing.Size(116, 32);
            this.lblRespostaC.TabIndex = 4;
            this.lblRespostaC.Text = "resposta3";
            this.lblRespostaC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRespostaD
            // 
            this.lblRespostaD.AutoSize = true;
            this.lblRespostaD.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespostaD.Location = new System.Drawing.Point(424, 482);
            this.lblRespostaD.Margin = new System.Windows.Forms.Padding(3);
            this.lblRespostaD.Name = "lblRespostaD";
            this.lblRespostaD.Size = new System.Drawing.Size(116, 32);
            this.lblRespostaD.TabIndex = 5;
            this.lblRespostaD.Text = "resposta4";
            this.lblRespostaD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnProxima
            // 
            this.btnProxima.BackColor = System.Drawing.Color.Aqua;
            this.btnProxima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProxima.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxima.ForeColor = System.Drawing.Color.Black;
            this.btnProxima.Location = new System.Drawing.Point(430, 602);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(223, 78);
            this.btnProxima.TabIndex = 10;
            this.btnProxima.Text = "NEXT";
            this.btnProxima.UseVisualStyleBackColor = false;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAnterior.Enabled = false;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnterior.Location = new System.Drawing.Point(62, 603);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(223, 78);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.Text = "BACK";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblNumPergunta
            // 
            this.lblNumPergunta.AutoSize = true;
            this.lblNumPergunta.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPergunta.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNumPergunta.Location = new System.Drawing.Point(104, 252);
            this.lblNumPergunta.Name = "lblNumPergunta";
            this.lblNumPergunta.Size = new System.Drawing.Size(74, 37);
            this.lblNumPergunta.TabIndex = 12;
            this.lblNumPergunta.Text = "num";
            // 
            // rbtnRespostaA
            // 
            this.rbtnRespostaA.AutoSize = true;
            this.rbtnRespostaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRespostaA.Location = new System.Drawing.Point(404, 366);
            this.rbtnRespostaA.Name = "rbtnRespostaA";
            this.rbtnRespostaA.Size = new System.Drawing.Size(14, 13);
            this.rbtnRespostaA.TabIndex = 13;
            this.rbtnRespostaA.TabStop = true;
            this.rbtnRespostaA.UseVisualStyleBackColor = true;
            // 
            // rbtnRespostaB
            // 
            this.rbtnRespostaB.AutoSize = true;
            this.rbtnRespostaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRespostaB.Location = new System.Drawing.Point(404, 409);
            this.rbtnRespostaB.Name = "rbtnRespostaB";
            this.rbtnRespostaB.Size = new System.Drawing.Size(14, 13);
            this.rbtnRespostaB.TabIndex = 14;
            this.rbtnRespostaB.TabStop = true;
            this.rbtnRespostaB.UseVisualStyleBackColor = true;
            // 
            // rbtnRespostaC
            // 
            this.rbtnRespostaC.AutoSize = true;
            this.rbtnRespostaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRespostaC.Location = new System.Drawing.Point(404, 452);
            this.rbtnRespostaC.Name = "rbtnRespostaC";
            this.rbtnRespostaC.Size = new System.Drawing.Size(14, 13);
            this.rbtnRespostaC.TabIndex = 15;
            this.rbtnRespostaC.TabStop = true;
            this.rbtnRespostaC.UseVisualStyleBackColor = true;
            // 
            // rbtnRespostaD
            // 
            this.rbtnRespostaD.AutoSize = true;
            this.rbtnRespostaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRespostaD.Location = new System.Drawing.Point(404, 495);
            this.rbtnRespostaD.Name = "rbtnRespostaD";
            this.rbtnRespostaD.Size = new System.Drawing.Size(14, 13);
            this.rbtnRespostaD.TabIndex = 16;
            this.rbtnRespostaD.TabStop = true;
            this.rbtnRespostaD.UseVisualStyleBackColor = true;
            // 
            // btnVerResultado
            // 
            this.btnVerResultado.BackColor = System.Drawing.Color.Tomato;
            this.btnVerResultado.Enabled = false;
            this.btnVerResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerResultado.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerResultado.ForeColor = System.Drawing.Color.White;
            this.btnVerResultado.Location = new System.Drawing.Point(949, 603);
            this.btnVerResultado.Name = "btnVerResultado";
            this.btnVerResultado.Size = new System.Drawing.Size(223, 78);
            this.btnVerResultado.TabIndex = 21;
            this.btnVerResultado.Text = "RESULTS";
            this.btnVerResultado.UseVisualStyleBackColor = false;
            this.btnVerResultado.Click += new System.EventHandler(this.btnVerResultado_Click);
            // 
            // lblExameNome
            // 
            this.lblExameNome.AutoSize = true;
            this.lblExameNome.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExameNome.Location = new System.Drawing.Point(104, 95);
            this.lblExameNome.Name = "lblExameNome";
            this.lblExameNome.Size = new System.Drawing.Size(44, 37);
            this.lblExameNome.TabIndex = 22;
            this.lblExameNome.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "D";
            // 
            // ExameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1249, 775);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExameNome);
            this.Controls.Add(this.btnVerResultado);
            this.Controls.Add(this.rbtnRespostaD);
            this.Controls.Add(this.rbtnRespostaC);
            this.Controls.Add(this.rbtnRespostaB);
            this.Controls.Add(this.rbtnRespostaA);
            this.Controls.Add(this.lblNumPergunta);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProxima);
            this.Controls.Add(this.lblRespostaD);
            this.Controls.Add(this.lblRespostaC);
            this.Controls.Add(this.lblRespostaB);
            this.Controls.Add(this.lblRespostaA);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.lblExit);
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Label lblRespostaA;
        private System.Windows.Forms.Label lblRespostaB;
        private System.Windows.Forms.Label lblRespostaC;
        private System.Windows.Forms.Label lblRespostaD;
        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblNumPergunta;
        private System.Windows.Forms.RadioButton rbtnRespostaA;
        private System.Windows.Forms.RadioButton rbtnRespostaB;
        private System.Windows.Forms.RadioButton rbtnRespostaC;
        private System.Windows.Forms.RadioButton rbtnRespostaD;
        private System.Windows.Forms.Button btnVerResultado;
        private System.Windows.Forms.Label lblExameNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}