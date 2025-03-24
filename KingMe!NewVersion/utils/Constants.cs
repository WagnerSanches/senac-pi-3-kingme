using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingMe_NewVersion.utils
{
    public class Constants
    {
        public static Dictionary<char, Color> mapaCores = new Dictionary<char, Color>
        {
            { 'A', Color.FromArgb(255, 0, 102) },   // Vermelho vibrante
            { 'B', Color.FromArgb(255, 128, 0) },   // Laranja forte
            { 'C', Color.FromArgb(255, 255, 0) },   // Amarelo neon
            { 'D', Color.FromArgb(0, 255, 0) },     // Verde limão
            { 'E', Color.FromArgb(0, 255, 255) },   // Azul turquesa
            { 'G', Color.FromArgb(0, 102, 255) },   // Azul elétrico
            { 'H', Color.FromArgb(128, 0, 255) },   // Roxo intenso
            { 'K', Color.FromArgb(255, 0, 255) },   // Rosa choque
            { 'L', Color.FromArgb(255, 51, 153) },  // Magenta vibrante
            { 'M', Color.FromArgb(204, 0, 204) },   // Violeta forte
            { 'Q', Color.FromArgb(255, 51, 51) },   // Vermelho cereja
            { 'R', Color.FromArgb(255, 102, 178) }, // Rosa intenso
            { 'T', Color.FromArgb(255, 255, 102) }  // Amarelo ouro
        };
    }
}
