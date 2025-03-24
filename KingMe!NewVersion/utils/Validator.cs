using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingMe_NewVersion.utils
{
    public class Validator
    {
        public static bool validateStatus(string status)
        {
            if (status.Contains("ERRO"))
            {
                MessageBox.Show(status, "Error!", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public static bool validateField(string value, string field)
        {
            if (value == null || value == "")
            {
                MessageBox.Show("Campo '" + field + "' está incorreto.");
                return false;
            }

            return true;
        }
    }
}
