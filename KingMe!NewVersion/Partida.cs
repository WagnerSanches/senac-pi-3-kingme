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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        int MY_FAVORITES_PLAYED = 5;
        Dictionary<string, int> historico = new Dictionary<string, int>();
        bool jogando = false;

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

        private void atualizarPartidaStatus(string status)
        {
            switch (status.Split('\n')[0].Split(',')[3].Trim())
            {
                case "P":
                    lblPartidaStatus.Text = "Promocao!";
                    Global.partida.etapa = "P";
                    lstSetores.Hide();
                    label3.Hide();
                    gpbVotacao.Hide();
                    lstPersonagens.Show();
                    label2.Show();
                    jogando = true;
                    break;

                case "S":
                    lblPartidaStatus.Text = "Selecao!";
                    Global.partida.etapa = "S";
                    lstPersonagens.Show();
                    label2.Show();
                    lstSetores.Show();
                    label3.Show();
                    gpbVotacao.Hide();
                    if(jogando)
                    {
                        jogando = false;
                        historico = new Dictionary<string, int>();
                        favoritos = new List<char>();
                        Global.player.votos = 4;
                        listarSetores();
                        listarPersonagens();
                        listarFavoritos();
                    }

                    break;
                case "V":
                    lblPartidaStatus.Text = "Votacao!";
                    Global.partida.etapa = "V";
                    lstPersonagens.Hide();
                    label2.Hide();
                    lstSetores.Hide();
                    label3.Hide();
                    gpbVotacao.Show();
                    jogando = true;
                    break;
                case "E":
                    
                    int pontuacao_player_um = Int32.Parse(lstPontuacao.Items[0].ToString().Replace("   ", ",").Split(',')[2]);
                    int pontuacao_player_dois = Int32.Parse(lstPontuacao.Items[1].ToString().Replace("   ", ",").Split(',')[2]);

                    if(pontuacao_player_um > pontuacao_player_dois)
                    {
                        string player = $"{lstPontuacao.Items[0].ToString().Replace("   ", ",").Split(',')[0]} ({lstPontuacao.Items[0].ToString().Replace("   ", ",").Split(',')[1]})";
                        MessageBox.Show($"Player {player} ganhou!");
                    } else
                    {
                        string player = $"{lstPontuacao.Items[1].ToString().Replace("   ", ",").Split(',')[0]} ({lstPontuacao.Items[1].ToString().Replace("   ", ",").Split(',')[1]})";
                        MessageBox.Show($"Player {player} ganhou!");
                    }

                    this.Close();
                    break;
            }
        }

        public void atualizarPontuacao()
        {
            string strJogadores = Jogo.ListarJogadores(Global.partida.id);
            string[] jogadores = strJogadores.Split('\n');

            lstPontuacao.Items.Clear();

            for (int i = 0; i < jogadores.Length - 1; i++)
                lstPontuacao.Items.Add(jogadores[i].Replace(",", "   "));
        }

        public async Task verificarVez()
        {
            while (true)
            {
                string status = Jogo.VerificarVez(Global.partida.id);
                if (Validator.validateStatus(status))
                {
                    atualizarPontuacao();

                    string[] hist = status.Replace("\r", "").Split('\n');
                    lstHistorico.Items.Clear();

                    for (int i = 1; i < hist.Length - 1; i++)
                    {
                        if (!historico.ContainsKey(hist[i].Split(',')[1].Trim()))
                        {
                            historico.Add(hist[i].Split(',')[1].Trim(), Int32.Parse(hist[i].Split(',')[0]));
                        } else
                        {
                            historico[hist[i].Split(',')[1].Trim()] = Int32.Parse(hist[i].Split(',')[0]);
                        }

                        lstHistorico.Items.Add(hist[i]);
                    }

                    atualizarPartidaStatus(status);

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

                await Task.Delay(1000); 
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
                    addFavorito(status[i].ToString(), Constants.mapaCores[status[i]]);
                }
            }

        }

        private async void Partida_Load(object sender, EventArgs e)
        {
            tabuleiro = new Tabuleiro();

            this.FormClosed += (s, args) => tabuleiro.Close();
            tabuleiro.Show();

            lblVotos.Text = Global.player.votos.ToString();

            loading.Image = global::KingMe_NewVersion.Properties.Resources.load;
            loading.Location = new System.Drawing.Point(270, 220);
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
            await verificarVez();

            await jogar();
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
            favorito.ForeColor = System.Drawing.Color.Black;

            this.panel1.Controls.Add(favorito);
            labels.Add(favorito);
        }

        private string selecao()
        {
            if (lstPersonagens.SelectedItem == null)
            {
                MessageBox.Show("Selecione um personagem!");
                return "ERRO";
            }

            if (lstSetores.SelectedItem == null)
            {
                MessageBox.Show("Selecione um setor!");
                return "ERRO";
            }

            string personagem = lstPersonagens.SelectedItem.ToString().Replace("\n", "")[0].ToString();
            int setor = Int32.Parse(lstSetores.SelectedItem.ToString().Replace("\n", "").Split(',')[0]);

            return Jogo.ColocarPersonagem(Global.player.id, Global.player.senha, setor, personagem);
        }

        private string votacao()
        {
            if (rdbSim.Checked == false && rdbNao.Checked == false)
            {
                MessageBox.Show("Selecione uma opcao!");
                return "ERRO";
            }

            string voto = rdbSim.Checked ? "S" : "N";

            if (rdbNao.Checked && Global.player.votos > 0)
            {
                Global.player.votos--;
                lblVotos.Text = Global.player.votos.ToString();
            }

            return Jogo.Votar(Global.player.id, Global.player.senha, voto);
        }

        private string promocao()
        {
            if (lstPersonagens.SelectedItem == null)
            {
                MessageBox.Show("Selecione um personagem!");
                return "ERRO";
            }

            string personagem = lstPersonagens.SelectedItem.ToString().Replace("\n", "")[0].ToString();

            return Jogo.Promover(Global.player.id, Global.player.senha, personagem);
        }

        private async void btnJogar_Click(object sender, EventArgs e)
        {

            string status = "";
            switch(Global.partida.etapa)
            {
                case "S":
                    status = selecao();
                    break;
                case "V":
                    status = votacao();
                    break;
                case "P":
                    status = promocao();
                    break;
            }

            if (Validator.validateStatus(status))
            {
                tabuleiro.atualizarTabuleiro();
                listarSetores();
                listarPersonagens();
                listarFavoritos();
                await verificarVez();
            }
        }

        private async Task jogar()
        {
            await verificarVez();
            await Task.Delay(500);

            int setor = 0;
            // 
            switch(Global.partida.etapa)
            {
                case "S":

                    for (int i = 1; i < 5; i++)
                    {
                        if (Global.setores[i] < 4)
                        {
                            setor = i;
                            break;
                        }
                    }

                    bool placed = false;

                    for(int i = 0; i < MY_FAVORITES_PLAYED; i++)
                    {
                        if (!historico.ContainsKey(favoritos[i].ToString().Trim()))
                        {
                            string status = Jogo.ColocarPersonagem(Global.player.id, Global.player.senha, setor, favoritos[i].ToString());
                            placed = true;
                            Console.WriteLine(status);
                            break;
                        }
                    }

                    if (placed == false)
                    {
                        for (int j = 0; j < lstPersonagens.Items.Count; j++)
                        {
                            string personagem = lstPersonagens.Items[j].ToString().Replace("\n", "")[0].ToString();

                            if (!historico.ContainsKey(personagem))
                            {
                                string status = Jogo.ColocarPersonagem(Global.player.id, Global.player.senha, setor, personagem);
                                break;
                            }
                        }

                    }

                    break;
                case "P":
                    
                    for(int i = 5; i > 0; i--)
                    {
                        List<string> personagens = historico.Keys.Where(k => historico[k] == i).ToList();

                        if (personagens.Count == 0) continue;

                        bool played = false;

                        personagens.ForEach(p =>
                        {
                            if (favoritos.Contains(p[0]))
                            {
                                string s  = Jogo.Promover(Global.player.id, Global.player.senha, p);
                                played = true;
                                return;
                            }
                        });

                        if (played) break;

                        string personagem = personagens[personagens.Count - 1];
                        personagens.Remove(personagem);
                        string status = Jogo.Promover(Global.player.id, Global.player.senha, personagem);
                    }
                    
                    break;
                case "V":
                    string rei = historico.FirstOrDefault(kv => kv.Value == 10).Key;
                    if (favoritos.Contains(rei[0]))
                    {
                        string status = Jogo.Votar(Global.player.id, Global.player.senha, "S");
                        
                    } else
                    {
                        string status = Jogo.Votar(Global.player.id, Global.player.senha, "N");

                        if(status.Contains("ERRO"))
                        {
                            Jogo.Votar(Global.player.id, Global.player.senha, "S");
                        } else
                        {
                            Global.player.votos--;
                            lblVotos.Text = Global.player.votos.ToString();
                        }
                    }

                    break;
            }

            tabuleiro.atualizarTabuleiro();

            await jogar();
        }
    }
}
