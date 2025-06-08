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
            { 'A', Color.FromArgb(204, 102, 102) },   // Vermelho terroso
            { 'B', Color.FromArgb(204, 153, 102) },   // Laranja suave
            { 'C', Color.FromArgb(204, 204, 102) },   // Amarelo mostarda
            { 'D', Color.FromArgb(102, 153, 102) },   // Verde musgo
            { 'E', Color.FromArgb(102, 153, 153) },   // Azul petróleo
            { 'G', Color.FromArgb(102, 102, 153) },   // Azul ardósia
            { 'H', Color.FromArgb(153, 102, 153) },   // Roxo suave
            { 'K', Color.FromArgb(204, 153, 204) },   // Rosa pálido
            { 'L', Color.FromArgb(204, 102, 153) },   // Magenta suave
            { 'M', Color.FromArgb(153, 102, 153) },   // Violeta suave
            { 'Q', Color.FromArgb(153, 102, 102) },   // Vermelho terracota
            { 'R', Color.FromArgb(204, 153, 178) },   // Rosa pó
            { 'T', Color.FromArgb(204, 204, 153) }    // Amarelo creme
        };
    }
}
