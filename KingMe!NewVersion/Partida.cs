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
    public partial class Partida: Form
    {
        public Partida()
        {
            InitializeComponent();
        }

        private Tabuleiro tabuleiro;
        List<Label> labels = new List<Label>();
        PictureBox loading = new PictureBox();
        List<char> favoritos = new List<char>();

        private void listarSetores()
        {
            string strSetores = Jogo.ListarSetores();
            string[] setores = strSetores.Split('\r');

            lstSetores.Items.Clear();

            for (int i = 0; i < setores.Length - 1; i++)
                lstSetores.Items.Add(setores[i]);
        }

        private void listarPersonagens()
        {
            string strPersonagens = Jogo.ListarPersonagens();
            string[] personagens = strPersonagens.Split('\r');
           
            lstPersonagens.Items.Clear();

            for (int i = 0; i < personagens.Length - 1; i++)
                lstPersonagens.Items.Add(personagens[i]);
        }

        public async void verificarVez()
        {
            while (true)
            {
                string status = Jogo.VerificarVez(Global.partida.id);

                if (Validator.validateStatus(status))
                {
                    int idJogadorVez = Int32.Parse(status.Split(',')[0]);
                    if (idJogadorVez == Global.player.id)
                    {
                        lblVez.Text = "Sua vez!";
                        gpbPartida.Show();
                        loading.Hide();

                        listarSetores();
                        listarPersonagens();
                        tabuleiro.atualizarTabuleiro();

                        break;
                    }
                    else
                    {
                        lblVez.Text = "Vez do jogador: " + idJogadorVez;
                        gpbPartida.Hide();
                        loading.Show();

                    }
                }

                await Task.Delay(2000); 
            }
        }

        private void listarFavoritos()
        {

            string status = Jogo.ListarCartas(Global.player.id, Global.player.senha).Replace("\r", "");

            if (Validator.validateStatus(status))
            {
                favoritos.Clear();

                for(int i = 0; i < labels.Count; i++)
                {
                    this.panel1.Controls.Remove(labels[i]);
                }

                labels.Clear();

                for (int i = 0; i < status.Length - 1; i++)
                {
                    favoritos.Add(status[i]);
                    Console.WriteLine(status[i]);
                    addFavorito(status[i].ToString(), Constants.mapaCores[status[i]]);
                }

            }
        }

        private void Partida_Load(object sender, EventArgs e)
        {
            tabuleiro = new Tabuleiro();

            this.FormClosed += (s, args) => tabuleiro.Close();
            tabuleiro.Show();


            loading.Image = global::KingMe_NewVersion.Properties.Resources.load;
            loading.Location = new System.Drawing.Point(370, 220);
            loading.Name = "pictureBox1";
            loading.Size = new System.Drawing.Size(60, 60);
            loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            loading.TabIndex = 0;
            loading.TabStop = false;
            this.Controls.Add(loading);
            loading.Hide();

            listarSetores();
            listarPersonagens();
            listarFavoritos();
            verificarVez();
        }


        private void addFavorito(string character, Color color)
        {
            Label favorito = new Label();

            favorito.AutoSize = true;
            favorito.BackColor = color;
            favorito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            favorito.Location = new System.Drawing.Point(10 + (80 * labels.Count), 9);
            favorito.Margin = new System.Windows.Forms.Padding(0);
            favorito.Name = "lblFavorito";
            favorito.Padding = new System.Windows.Forms.Padding(20);
            favorito.Size = new System.Drawing.Size(75, 70);
            favorito.TabIndex = 0;
            favorito.Text = character;
            favorito.AutoSize = false; 
            favorito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            favorito.ForeColor = System.Drawing.Color.White;

            this.panel1.Controls.Add(favorito);
            labels.Add(favorito);
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (lstPersonagens.SelectedItem == null)
            {
                MessageBox.Show("Selecione um personagem!");
                return;
            }

            if (lstSetores.SelectedItem == null)
            {
                MessageBox.Show("Selecione um setor!");
                return;
            }

            string personagem = lstPersonagens.SelectedItem.ToString().Replace("\n", "")[0].ToString();
            int setor = Int32.Parse(lstSetores.SelectedItem.ToString().Replace("\n", "").Split(',')[0]);

            string status = Jogo.ColocarPersonagem(Global.player.id, Global.player.senha, setor, personagem);

            if(Validator.validateStatus(status))
            {
                listarSetores();
                listarPersonagens();
                listarFavoritos();
                verificarVez();
                tabuleiro.atualizarTabuleiro();
            }
        }
    }
}
