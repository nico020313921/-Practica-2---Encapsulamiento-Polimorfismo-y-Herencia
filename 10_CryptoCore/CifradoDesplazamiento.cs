using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CryptoCore
{
    public class CifradoDesplazamiento : Mensaje
    {
        public int ClaveNumerica { get; set; }

        public override string Cifrar()
        {
            if (string.IsNullOrEmpty(TextoOriginal)) return "";

            char[] caracteres = TextoOriginal.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                char c = caracteres[i];
                if (char.IsUpper(c))
                {
                    caracteres[i] = (char)((((c - 'A') + ClaveNumerica) % 26) + 'A');
                }
                else if (char.IsLower(c))
                {
                    caracteres[i] = (char)((((c - 'a') + ClaveNumerica) % 26) + 'a');
                }
            }

            return new string(caracteres);
        }
    }
}
