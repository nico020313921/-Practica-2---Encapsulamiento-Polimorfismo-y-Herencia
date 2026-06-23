using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CryptoCore
{
    public class CifradoInvertido : Mensaje
    {
        public override string Cifrar()
        {
            if (string.IsNullOrEmpty(TextoOriginal)) return "";

            char[] caracteres = TextoOriginal.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}
