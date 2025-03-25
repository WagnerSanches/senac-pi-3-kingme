using KingMe_NewVersion.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingMe_NewVersion.utils;

namespace KingMe_NewVersion.utils
{
    public class Global
    {
        public static Player player;
        public static Match partida;
        public static List<string> jogadas;
        public static int[] setores = new int[] { 0, 0, 0, 0, 0, 0 };
    }
}
