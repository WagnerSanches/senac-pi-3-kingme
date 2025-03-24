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
    public partial class Principal: Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void buscarPartida(string tipoPartida)
        {
            string[] partidas = Jogo.ListarPartidas(tipoPartida).Split('\r');

            if (lstPartidas.Items.Count > 0)
                lstPartidas.Items.Clear();

            for (int i = 0; i < partidas.Length - 1; i++)
                lstPartidas.Items.Add(partidas[i]);
        }

        private void listarJogadores(int idPartida)
        {
            string[] jogadores = Jogo.ListarJogadores(idPartida).Split('\r');

            if (lstPartidas.Items.Count > 0)
                lstListaJogadores.Items.Clear();

            for (int i = 0; i < jogadores.Length - 1; i++)
                lstListaJogadores.Items.Add(jogadores[i].Split(',')[1]);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.lblNomeJogador.Text = Global.player.nome;
            buscarPartida("T");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            buscarPartida("T");
        }

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPartidas.SelectedItem == null) return;
            Match partida = new Match(lstPartidas.SelectedItem.ToString().Replace("\n", "").Split(','));

            lblInfoPartida_Id.Text = partida.id.ToString();
            lblInfoPartida_Nome.Text = partida.nome;
            lblInfoPartida_Status.Text = partida.status;
            lblInfoPartida_Data.Text = partida.data;

            Global.partida = partida;
            btnPartida_Entrar.Enabled = true;

            listarJogadores(partida.id);
        }

        private void btnPartida_Entrar_Click(object sender, EventArgs e)
        {
            if(Validator.validateField(txtInfoPartida_Senha.Text, "senha da partida"))
            {
                string status = Jogo.Entrar(Global.partida.id, Global.player.nome, txtInfoPartida_Senha.Text);

                if(Validator.validateStatus(status))
                {
                    Global.player.InformacoesPlayerPartida(status);
                    Espera espera = new Espera();
                    this.Hide();
                    espera.Show();
                    espera.FormClosed += (s, args) => this.Close();
                }
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            NovaPartida novaPartida = new NovaPartida();
            novaPartida.FormClosed += (s, args) => {
                MessageBox.Show("Partida criada com sucesso!");
                this.buscarPartida("T");
            };
            novaPartida.ShowDialog();
        }
    }
}
