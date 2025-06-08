namespace KingMe_NewVersion
{
    partial class Partida
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
            this.gpbPartida = new System.Windows.Forms.GroupBox();
            this.gpbVotacao = new System.Windows.Forms.GroupBox();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSetores = new System.Windows.Forms.ListBox();
            this.lstPersonagens = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblVez = new System.Windows.Forms.Label();
            this.lblPartidaStatus = new System.Windows.Forms.Label();
            this.lstPontuacao = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVotos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstHistorico = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gpbPartida.SuspendLayout();
            this.gpbVotacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPartida
            // 
            this.gpbPartida.Controls.Add(this.gpbVotacao);
            this.gpbPartida.Controls.Add(this.label3);
            this.gpbPartida.Controls.Add(this.label2);
            this.gpbPartida.Controls.Add(this.label1);
            this.gpbPartida.Controls.Add(this.lstSetores);
            this.gpbPartida.Controls.Add(this.lstPersonagens);
            this.gpbPartida.Controls.Add(this.panel1);
            this.gpbPartida.Controls.Add(this.btnJogar);
            this.gpbPartida.Location = new System.Drawing.Point(12, 77);
            this.gpbPartida.Name = "gpbPartida";
            this.gpbPartida.Size = new System.Drawing.Size(590, 372);
            this.gpbPartida.TabIndex = 0;
            this.gpbPartida.TabStop = false;
            this.gpbPartida.Text = "Partida";
            // 
            // gpbVotacao
            // 
            this.gpbVotacao.Controls.Add(this.rdbSim);
            this.gpbVotacao.Controls.Add(this.rdbNao);
            this.gpbVotacao.Location = new System.Drawing.Point(369, 196);
            this.gpbVotacao.Name = "gpbVotacao";
            this.gpbVotacao.Size = new System.Drawing.Size(200, 100);
            this.gpbVotacao.TabIndex = 10;
            this.gpbVotacao.TabStop = false;
            this.gpbVotacao.Text = "Votacao";
            this.gpbVotacao.Visible = false;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(17, 32);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(42, 17);
            this.rdbSim.TabIndex = 7;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(17, 55);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(45, 17);
            this.rdbNao.TabIndex = 8;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Nao";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Setores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Personagens";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sua carta de favoritos";
            // 
            // lstSetores
            // 
            this.lstSetores.FormattingEnabled = true;
            this.lstSetores.Location = new System.Drawing.Point(181, 212);
            this.lstSetores.Name = "lstSetores";
            this.lstSetores.Size = new System.Drawing.Size(140, 121);
            this.lstSetores.TabIndex = 3;
            // 
            // lstPersonagens
            // 
            this.lstPersonagens.FormattingEnabled = true;
            this.lstPersonagens.Location = new System.Drawing.Point(6, 212);
            this.lstPersonagens.Name = "lstPersonagens";
            this.lstPersonagens.Size = new System.Drawing.Size(140, 121);
            this.lstPersonagens.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(6, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 91);
            this.panel1.TabIndex = 1;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(494, 334);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblVez
            // 
            this.lblVez.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVez.AutoSize = true;
            this.lblVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVez.Location = new System.Drawing.Point(414, 29);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(40, 20);
            this.lblVez.TabIndex = 1;
            this.lblVez.Text = "Vez";
            this.lblVez.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartidaStatus
            // 
            this.lblPartidaStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPartidaStatus.AutoSize = true;
            this.lblPartidaStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaStatus.Location = new System.Drawing.Point(417, 49);
            this.lblPartidaStatus.Name = "lblPartidaStatus";
            this.lblPartidaStatus.Size = new System.Drawing.Size(37, 20);
            this.lblPartidaStatus.TabIndex = 3;
            this.lblPartidaStatus.Text = "Vez";
            this.lblPartidaStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstPontuacao
            // 
            this.lstPontuacao.FormattingEnabled = true;
            this.lstPontuacao.Location = new System.Drawing.Point(611, 97);
            this.lstPontuacao.Name = "lstPontuacao";
            this.lstPontuacao.Size = new System.Drawing.Size(241, 56);
            this.lstPontuacao.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pontuação";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Votos \'Nao\' restantes: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVotos
            // 
            this.lblVotos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVotos.AutoSize = true;
            this.lblVotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotos.Location = new System.Drawing.Point(202, 49);
            this.lblVotos.Name = "lblVotos";
            this.lblVotos.Size = new System.Drawing.Size(18, 20);
            this.lblVotos.TabIndex = 13;
            this.lblVotos.Text = "0";
            this.lblVotos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(711, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Historico";
            // 
            // lstHistorico
            // 
            this.lstHistorico.FormattingEnabled = true;
            this.lstHistorico.Location = new System.Drawing.Point(611, 172);
            this.lstHistorico.Name = "lstHistorico";
            this.lstHistorico.Size = new System.Drawing.Size(241, 277);
            this.lstHistorico.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mercadores de Bruges";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KingMe_NewVersion.Properties.Resources.wall_background;
            this.ClientSize = new System.Drawing.Size(865, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstHistorico);
            this.Controls.Add(this.lblVotos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstPontuacao);
            this.Controls.Add(this.lblPartidaStatus);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.gpbPartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Partida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partida";
            this.Load += new System.EventHandler(this.Partida_Load);
            this.gpbPartida.ResumeLayout(false);
            this.gpbPartida.PerformLayout();
            this.gpbVotacao.ResumeLayout(false);
            this.gpbVotacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPartida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSetores;
        private System.Windows.Forms.ListBox lstPersonagens;
        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.Label lblPartidaStatus;
        private System.Windows.Forms.GroupBox gpbVotacao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.ListBox lstPontuacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVotos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstHistorico;
        private System.Windows.Forms.Label label7;
    }
}