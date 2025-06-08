namespace KingMe_NewVersion
{
    partial class Principal
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
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInfoPartida_Senha = new System.Windows.Forms.TextBox();
            this.btnPartida_Entrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstListaJogadores = new System.Windows.Forms.ListBox();
            this.lblInfoPartida_Data = new System.Windows.Forms.Label();
            this.lblInfoPartida_Status = new System.Windows.Forms.Label();
            this.lblInfoPartida_Id = new System.Windows.Forms.Label();
            this.lblInfoPartida_Nome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(447, 64);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(132, 18);
            this.lblNomeJogador.TabIndex = 0;
            this.lblNomeJogador.Text = "lblNomeJogador";
            // 
            // lstPartidas
            // 
            this.lstPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 20;
            this.lstPartidas.Location = new System.Drawing.Point(26, 116);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(440, 224);
            this.lstPartidas.TabIndex = 2;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImage = global::KingMe_NewVersion.Properties.Resources.reload;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.Location = new System.Drawing.Point(35, 346);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(32, 32);
            this.btnReload.TabIndex = 3;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KingMe_NewVersion.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(387, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtInfoPartida_Senha);
            this.groupBox1.Controls.Add(this.btnPartida_Entrar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lstListaJogadores);
            this.groupBox1.Controls.Add(this.lblInfoPartida_Data);
            this.groupBox1.Controls.Add(this.lblInfoPartida_Status);
            this.groupBox1.Controls.Add(this.lblInfoPartida_Id);
            this.groupBox1.Controls.Add(this.lblInfoPartida_Nome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(475, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 297);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMAÇÔES DA PARTIDA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "SENHA DA PARTIDA";
            // 
            // txtInfoPartida_Senha
            // 
            this.txtInfoPartida_Senha.Location = new System.Drawing.Point(21, 203);
            this.txtInfoPartida_Senha.Name = "txtInfoPartida_Senha";
            this.txtInfoPartida_Senha.Size = new System.Drawing.Size(196, 21);
            this.txtInfoPartida_Senha.TabIndex = 14;
            // 
            // btnPartida_Entrar
            // 
            this.btnPartida_Entrar.Enabled = false;
            this.btnPartida_Entrar.Location = new System.Drawing.Point(21, 230);
            this.btnPartida_Entrar.Name = "btnPartida_Entrar";
            this.btnPartida_Entrar.Size = new System.Drawing.Size(135, 23);
            this.btnPartida_Entrar.TabIndex = 5;
            this.btnPartida_Entrar.Text = "Entrar na partida";
            this.btnPartida_Entrar.UseVisualStyleBackColor = true;
            this.btnPartida_Entrar.Click += new System.EventHandler(this.btnPartida_Entrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "JOGADORES";
            // 
            // lstListaJogadores
            // 
            this.lstListaJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaJogadores.FormattingEnabled = true;
            this.lstListaJogadores.ItemHeight = 15;
            this.lstListaJogadores.Location = new System.Drawing.Point(317, 57);
            this.lstListaJogadores.Name = "lstListaJogadores";
            this.lstListaJogadores.Size = new System.Drawing.Size(142, 214);
            this.lstListaJogadores.TabIndex = 5;
            // 
            // lblInfoPartida_Data
            // 
            this.lblInfoPartida_Data.AutoSize = true;
            this.lblInfoPartida_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPartida_Data.Location = new System.Drawing.Point(130, 97);
            this.lblInfoPartida_Data.Name = "lblInfoPartida_Data";
            this.lblInfoPartida_Data.Size = new System.Drawing.Size(0, 15);
            this.lblInfoPartida_Data.TabIndex = 12;
            // 
            // lblInfoPartida_Status
            // 
            this.lblInfoPartida_Status.AutoSize = true;
            this.lblInfoPartida_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPartida_Status.Location = new System.Drawing.Point(86, 77);
            this.lblInfoPartida_Status.Name = "lblInfoPartida_Status";
            this.lblInfoPartida_Status.Size = new System.Drawing.Size(0, 15);
            this.lblInfoPartida_Status.TabIndex = 11;
            // 
            // lblInfoPartida_Id
            // 
            this.lblInfoPartida_Id.AutoSize = true;
            this.lblInfoPartida_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPartida_Id.Location = new System.Drawing.Point(49, 36);
            this.lblInfoPartida_Id.Name = "lblInfoPartida_Id";
            this.lblInfoPartida_Id.Size = new System.Drawing.Size(0, 15);
            this.lblInfoPartida_Id.TabIndex = 10;
            // 
            // lblInfoPartida_Nome
            // 
            this.lblInfoPartida_Nome.AutoSize = true;
            this.lblInfoPartida_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPartida_Nome.Location = new System.Drawing.Point(163, 57);
            this.lblInfoPartida_Nome.Name = "lblInfoPartida_Nome";
            this.lblInfoPartida_Nome.Size = new System.Drawing.Size(0, 15);
            this.lblInfoPartida_Nome.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "DATA CRIAÇÃO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "STATUS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOME DA PARTIDA: ";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(325, 346);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(141, 32);
            this.btnCriarPartida.TabIndex = 16;
            this.btnCriarPartida.Text = "Criar nova partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Playbill", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 40);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mercadores de Bruges";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KingMe_NewVersion.Properties.Resources.wall_background;
            this.ClientSize = new System.Drawing.Size(984, 489);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNomeJogador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInfoPartida_Status;
        private System.Windows.Forms.Label lblInfoPartida_Id;
        private System.Windows.Forms.Label lblInfoPartida_Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfoPartida_Data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstListaJogadores;
        private System.Windows.Forms.Button btnPartida_Entrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInfoPartida_Senha;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label label7;
    }
}