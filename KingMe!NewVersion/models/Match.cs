using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingMe_NewVersion.models
{
    public class Match
    {
        public int id;
        public string nome;
        public string status;
        public string data;
        public string etapa;

        public Match(string[] values)
        {
            this.id = Int32.Parse(values[0]);
            this.nome = values[1];
            this.data = values[2];
            switch(values[3])
            {
                case "A":
                    this.status = "ABERTA";
                    break;
                case "J":
                    this.status = "JOGANDO";
                    break;
                case "F":
                    this.status = "FINALIZADA";
                    break;

            }
        }

        public Match(string id)
        {
            this.id = Int32.Parse(id);
        }
    }
}
