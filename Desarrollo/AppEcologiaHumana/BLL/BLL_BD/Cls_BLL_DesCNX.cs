using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_BD
{
    public class Cls_BLL_DesCNX
    {
        public string EncriptCadena(string sCadenaEncriptar)
        {
            try
            {
                string sResultado = string.Empty;
                byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(sCadenaEncriptar);

                sResultado = Convert.ToBase64String(encrypted);

                return sResultado;
            }
            catch
            {
                return string.Empty;
            }
        }

        public string DesencriptCadena(string sCadenaDesencriptar)
        {
            try
            {
                string sResultado = string.Empty;
                byte[] decrypted = Convert.FromBase64String(sCadenaDesencriptar);

                sResultado = System.Text.Encoding.Unicode.GetString(decrypted);

                return sResultado;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
