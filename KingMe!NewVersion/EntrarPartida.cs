using KingMe_NewVersion.utils;
using KingMeServer;
using System;
using System.Windows.Forms;

namespace KingMe_NewVersion
{
    public partial class EntrarPartida: Form
    {
        public EntrarPartida()
        {
            InitializeComponent();
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            if (Validator.validateField(txtIdUsuario.Text, "id do jogador") &&
                Validator.validateField(txtSenhaUsuario.Text, "senha do jogador") &&
                Validator.validateField(txtIniciarIdPartida.Text, "ID da partida"))
            {
                try
                {

                    Global.player = new models.Player("");
                    Global.player.id = Int32.Parse(txtIdUsuario.Text);
                    Global.player.senha = txtSenhaUsuario.Text;

                    Global.partida = new models.Match(txtIniciarIdPartida.Text);

                    Partida partida = new Partida();
                    this.Hide();
                    partida.FormClosed += (s, args) => this.Close();
                    partida.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor digite os campos corretamente!");
                }
            }
        }
    }
}
