using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10_CryptoCore
{
    public class Mensaje
    {
        private string _textoOriginal;

        public string TextoOriginal
        {
            get { return _textoOriginal; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z áéíóúÁÉÍÓÚñÑ]+$"))
                {
                    _textoOriginal = value;
                }
                else
                {
                    Console.WriteLine("Error: El texto contiene caracteres especiales no permitidos.");
                    _textoOriginal = "Texto Invalido";
                }
            }
        }

        public virtual string Cifrar()
        {
            return TextoOriginal;
        }
    }
}
