using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingMe_NewVersion.models
{
    public class Player
    {
        public int id;
        public string nome;
        public string senha;
        public string pontos;

        public Player(string nome)
        {
            this.nome = nome;
        }

        public void InformacoesPlayerPartida(string partida)
        {
            this.id = Int32.Parse(partida.Replace("\n", "").Split(',')[0]);
            this.senha = partida.Replace("\n", "").Split(',')[1];
        }
    }
}
