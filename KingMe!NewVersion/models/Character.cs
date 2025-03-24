using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingMe_NewVersion.models
{
    public class Character
    {
        public int setor;
        public string nome;

        public Character(string setor, string nome)
        {
            this.setor = Int32.Parse(setor);
            this.nome = nome;
        }
    }
}
