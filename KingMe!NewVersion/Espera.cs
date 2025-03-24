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
    public partial class Espera: Form
    {
        public Espera()
        {
            InitializeComponent();
        }

        private void listarJogadores(int idPartida)
        {
            string[] jogadores = Jogo.ListarJogadores(idPartida).Split('\r');

            lstListaJogadores.Items.Clear();

            for (int i = 0; i < jogadores.Length - 1; i++)
                lstListaJogadores.Items.Add(jogadores[i].Split(',')[1]);
        }

        private void Espera_Load(object sender, EventArgs e)
        {
            lblInfoPartida.Text = $"{Global.partida.id} - {Global.partida.nome}";
            this.lblNomeJogador.Text = Global.player.nome;
            this.lblIDJogador.Text = Global.player.id.ToString();
            this.lblSenhaJogador.Text = Global.player.senha;

            listarJogadores(Global.partida.id);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            listarJogadores(Global.partida.id);
        }

        private void btnComecarPartida_Click(object sender, EventArgs e)
        {
            string status = Jogo.Iniciar(Global.player.id, Global.player.senha);

            if(status == "ERRO:Partida não está aberta")
            {
                Partida partida = new Partida();
                this.Hide();
                partida.FormClosed += (s, args) => this.Close();
                partida.Show();
            } else
            {
                if (Validator.validateStatus(status))
                {
                    Partida partida = new Partida();
                    this.Hide();
                    partida.Show();
                    partida.FormClosed += (s, args) => this.Close();
                }
            }


        }
    }
}
