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
    public partial class Tabuleiro: Form
    {
        
        List<Label> personagens = new List<Label>();
        public Tabuleiro()
        {
            InitializeComponent();
        }

        private void Tabuleiro_Load(object sender, EventArgs e)
        {
            atualizarTabuleiro();

        }

        private void limparTabuleiro()
        {
            if(personagens.Count > 0)
            {
                for(int i = 0; i < personagens.Count; i++)
                {
                    this.Controls.Remove(personagens[i]);

                }
                personagens.Clear();
                Global.setores = new int[] { 0, 0, 0, 0, 0, 0 };
            }
        }

        public void atualizarTabuleiro()
        {
            limparTabuleiro();
            string status = Jogo.VerificarVez(Global.partida.id);

            if (Validator.validateStatus(status))
            {
                string[] partida = status.Replace("\r", "").Split('\n');

                if(partida.Length > 0)
                {
                    for(int i = 1; i < partida.Length - 1; i++)
                    {
                        string setores = partida[i].Split(',')[0];
                        string personagem = partida[i].Split(',')[1];

                        addCharacter(new Character(setores, personagem));
                    }
                }
            }
        }

        private void addCharacter(Character character)
        {
            Label label = new Label();

            label.AutoSize = true;
            label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (character.setor == 10)
                character.setor = 5;

            int x = ((Global.setores[character.setor]) * 60) + 129;
            int y = 205 + ((5 - character.setor) * 100);
            Global.setores[character.setor]++;

            label.BackColor = Constants.mapaCores[character.nome[0]];
            label.Location = new System.Drawing.Point(x, y);
            label.Name = "lbl";
            label.Padding = new System.Windows.Forms.Padding(15);
            label.Size = new System.Drawing.Size(50, 50);
            label.TabIndex = 2;
            label.Text = character.nome;

            personagens.Add(label);
            this.Controls.Add(label);
            label.BringToFront();
        }
    }
}
