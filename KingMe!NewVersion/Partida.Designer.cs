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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSetores = new System.Windows.Forms.ListBox();
            this.lstPersonagens = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblVez = new System.Windows.Forms.Label();
            this.gpbPartida.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPartida
            // 
            this.gpbPartida.Controls.Add(this.label3);
            this.gpbPartida.Controls.Add(this.label2);
            this.gpbPartida.Controls.Add(this.label1);
            this.gpbPartida.Controls.Add(this.lstSetores);
            this.gpbPartida.Controls.Add(this.lstPersonagens);
            this.gpbPartida.Controls.Add(this.panel1);
            this.gpbPartida.Controls.Add(this.btnJogar);
            this.gpbPartida.Location = new System.Drawing.Point(12, 65);
            this.gpbPartida.Name = "gpbPartida";
            this.gpbPartida.Size = new System.Drawing.Size(760, 384);
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
            this.lblVez.Location = new System.Drawing.Point(337, 20);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(40, 20);
            this.lblVez.TabIndex = 1;
            this.lblVez.Text = "Vez";
            this.lblVez.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.gpbPartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Partida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partida";
            this.Load += new System.EventHandler(this.Partida_Load);
            this.gpbPartida.ResumeLayout(false);
            this.gpbPartida.PerformLayout();
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
    }
}