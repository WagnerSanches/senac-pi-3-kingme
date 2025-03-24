namespace KingMe_NewVersion
{
    partial class Espera
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
            this.btnComecarPartida = new System.Windows.Forms.Button();
            this.lstListaJogadores = new System.Windows.Forms.ListBox();
            this.lblInfoPartida = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblIDJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComecarPartida
            // 
            this.btnComecarPartida.Location = new System.Drawing.Point(200, 514);
            this.btnComecarPartida.Name = "btnComecarPartida";
            this.btnComecarPartida.Size = new System.Drawing.Size(75, 23);
            this.btnComecarPartida.TabIndex = 0;
            this.btnComecarPartida.Text = "COMECAR";
            this.btnComecarPartida.UseVisualStyleBackColor = true;
            this.btnComecarPartida.Click += new System.EventHandler(this.btnComecarPartida_Click);
            // 
            // lstListaJogadores
            // 
            this.lstListaJogadores.FormattingEnabled = true;
            this.lstListaJogadores.Location = new System.Drawing.Point(71, 146);
            this.lstListaJogadores.Name = "lstListaJogadores";
            this.lstListaJogadores.Size = new System.Drawing.Size(323, 277);
            this.lstListaJogadores.TabIndex = 1;
            // 
            // lblInfoPartida
            // 
            this.lblInfoPartida.AutoSize = true;
            this.lblInfoPartida.Location = new System.Drawing.Point(220, 96);
            this.lblInfoPartida.Name = "lblInfoPartida";
            this.lblInfoPartida.Size = new System.Drawing.Size(35, 13);
            this.lblInfoPartida.TabIndex = 2;
            this.lblInfoPartida.Text = "label1";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(82, 429);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KingMe_NewVersion.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(129, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(189, 18);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(132, 18);
            this.lblNomeJogador.TabIndex = 4;
            this.lblNomeJogador.Text = "lblNomeJogador";
            // 
            // lblIDJogador
            // 
            this.lblIDJogador.AutoSize = true;
            this.lblIDJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDJogador.Location = new System.Drawing.Point(220, 36);
            this.lblIDJogador.Name = "lblIDJogador";
            this.lblIDJogador.Size = new System.Drawing.Size(91, 18);
            this.lblIDJogador.TabIndex = 6;
            this.lblIDJogador.Text = "lblIDJogador";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogador.Location = new System.Drawing.Point(252, 54);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(119, 18);
            this.lblSenhaJogador.TabIndex = 7;
            this.lblSenhaJogador.Text = "lblSenhaJogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Senha: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID: ";
            // 
            // Espera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblIDJogador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lblInfoPartida);
            this.Controls.Add(this.lstListaJogadores);
            this.Controls.Add(this.btnComecarPartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Espera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espera";
            this.Load += new System.EventHandler(this.Espera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComecarPartida;
        private System.Windows.Forms.ListBox lstListaJogadores;
        private System.Windows.Forms.Label lblInfoPartida;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Label lblIDJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}