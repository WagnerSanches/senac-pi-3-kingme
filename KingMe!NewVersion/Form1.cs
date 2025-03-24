using KingMe_NewVersion.models;
using KingMe_NewVersion.utils;
using KingMeServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingMe_NewVersion
{
    public partial class Form1: Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblJogo_Versao.Text = $"VERSAO {Jogo.versao}";
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeJogador.Text;
            Global.player = new Player(nome);

            Principal principal = new Principal();
            this.Hide();
            principal.Show();
            principal.FormClosed += (s, args) => this.Close();
        }

        private void btnEntrarPartidaExistente_Click(object sender, EventArgs e)
        {
            EntrarPartida entrarPartida = new EntrarPartida();
            this.Hide();
            entrarPartida.Show();
            entrarPartida.FormClosed += (s, args) => this.Close();
        }
    }
}
