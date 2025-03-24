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
    public partial class NovaPartida: Form
    {
        public NovaPartida()
        {
            InitializeComponent();
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            if (Validator.validateField(txtNomePartida.Text, "novo nome da partida") &&
                Validator.validateField(txtSenhaPartida.Text, "nova senha da partida") &&
                Validator.validateField(txtNomeGrupo.Text, "nome do grupo"))
            {
                string status = Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text, txtNomeGrupo.Text);
                if(Validator.validateStatus(status))
                    this.Close();
            }
        }

        private void NovaPartida_Load(object sender, EventArgs e)
        {

        }
    }
}
