using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace deve_web.Logic
{
    public class SecurityLogic
    {
        /// Esta función "encripta" la cadena que le envíamos en el parámentro de entrada.
        public static string Encriptar(string secretString)
        {
            string result = string.Empty;
            byte[] encryted =
            System.Text.Encoding.Unicode.GetBytes(secretString);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función "desencripta" la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(string secretString)
        {
            string result = string.Empty;
            byte[] decryted =
            Convert.FromBase64String(secretString);
            //result = 
            System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}