﻿namespace KingMe_NewVersion
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSetores = new System.Windows.Forms.ListBox();
            this.lstPersonagens = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblVez = new System.Windows.Forms.Label();
            this.lblVezInfo = new System.Windows.Forms.Label();
            this.lblPartidaStatus = new System.Windows.Forms.Label();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.gpbVotacao = new System.Windows.Forms.GroupBox();
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
            this.gpbPartida.Size = new System.Drawing.Size(760, 372);
            this.gpbPartida.TabIndex = 0;
            this.gpbPartida.TabStop = false;
            this.gpbPartida.Text = "Partida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 196);
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
            this.lstSetores.Location = new System.Drawing.Point(244, 212);
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
            this.panel1.Size = new System.Drawing.Size(748, 91);
            this.panel1.TabIndex = 1;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(658, 342);
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
            this.lblVez.Location = new System.Drawing.Point(343, 30);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(40, 20);
            this.lblVez.TabIndex = 1;
            this.lblVez.Text = "Vez";
            this.lblVez.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVezInfo
            // 
            this.lblVezInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVezInfo.AutoSize = true;
            this.lblVezInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVezInfo.Location = new System.Drawing.Point(17, 9);
            this.lblVezInfo.Name = "lblVezInfo";
            this.lblVezInfo.Size = new System.Drawing.Size(40, 20);
            this.lblVezInfo.TabIndex = 2;
            this.lblVezInfo.Text = "Vez";
            this.lblVezInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartidaStatus
            // 
            this.lblPartidaStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPartidaStatus.AutoSize = true;
            this.lblPartidaStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaStatus.Location = new System.Drawing.Point(343, 9);
            this.lblPartidaStatus.Name = "lblPartidaStatus";
            this.lblPartidaStatus.Size = new System.Drawing.Size(37, 20);
            this.lblPartidaStatus.TabIndex = 3;
            this.lblPartidaStatus.Text = "Vez";
            this.lblPartidaStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // gpbVotacao
            // 
            this.gpbVotacao.Controls.Add(this.rdbSim);
            this.gpbVotacao.Controls.Add(this.rdbNao);
            this.gpbVotacao.Location = new System.Drawing.Point(456, 196);
            this.gpbVotacao.Name = "gpbVotacao";
            this.gpbVotacao.Size = new System.Drawing.Size(200, 100);
            this.gpbVotacao.TabIndex = 10;
            this.gpbVotacao.TabStop = false;
            this.gpbVotacao.Text = "Votacao";
            this.gpbVotacao.Visible = false;
            // 
            // Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblPartidaStatus);
            this.Controls.Add(this.lblVezInfo);
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
        private System.Windows.Forms.Label lblVezInfo;
        private System.Windows.Forms.Label lblPartidaStatus;
        private System.Windows.Forms.GroupBox gpbVotacao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.RadioButton rdbNao;
    }
}