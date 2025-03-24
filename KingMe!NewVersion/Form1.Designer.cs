namespace KingMe_NewVersion
{
    partial class Form1
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
            this.lblJogo_Versao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnEntrarPartidaExistente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJogo_Versao
            // 
            this.lblJogo_Versao.AutoSize = true;
            this.lblJogo_Versao.Location = new System.Drawing.Point(259, 101);
            this.lblJogo_Versao.Name = "lblJogo_Versao";
            this.lblJogo_Versao.Size = new System.Drawing.Size(51, 13);
            this.lblJogo_Versao.TabIndex = 5;
            this.lblJogo_Versao.Text = "VERSÃO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Home-PC\\source\\repos\\KingMe!NewVersion\\KingMe!NewVersion\\images\\kingme.p" +
    "ng";
            this.pictureBox1.Location = new System.Drawing.Point(160, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 86);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOME DO JOGADOR";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogador.Location = new System.Drawing.Point(177, 190);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(228, 30);
            this.txtNomeJogador.TabIndex = 8;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnJogar.Location = new System.Drawing.Point(219, 226);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(144, 41);
            this.btnJogar.TabIndex = 9;
            this.btnJogar.Text = "JOGAR!";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnEntrarPartidaExistente
            // 
            this.btnEntrarPartidaExistente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEntrarPartidaExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarPartidaExistente.ForeColor = System.Drawing.Color.Transparent;
            this.btnEntrarPartidaExistente.Location = new System.Drawing.Point(160, 287);
            this.btnEntrarPartidaExistente.Name = "btnEntrarPartidaExistente";
            this.btnEntrarPartidaExistente.Size = new System.Drawing.Size(265, 41);
            this.btnEntrarPartidaExistente.TabIndex = 10;
            this.btnEntrarPartidaExistente.Text = "ENTRAR EM UMA PARTIDA EXISTENTE";
            this.btnEntrarPartidaExistente.UseVisualStyleBackColor = false;
            this.btnEntrarPartidaExistente.Click += new System.EventHandler(this.btnEntrarPartidaExistente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnEntrarPartidaExistente);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblJogo_Versao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJogo_Versao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnEntrarPartidaExistente;
    }
}

