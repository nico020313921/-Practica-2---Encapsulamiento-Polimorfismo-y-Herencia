using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_SecureBank
{
    public class Transaccion
    {
        private string _tokenSeguridad;

        public string TokenSeguridad
        {
            get { return _tokenSeguridad; }
            set
            {
                if (value != null && value.Length == 8)
                {
                    _tokenSeguridad = value;
                }
                else
                {
                    _tokenSeguridad = "INVALIDO";
                }
            }
        }

        public virtual string Procesar()
        {
            if (_tokenSeguridad == "INVALIDO" || string.IsNullOrEmpty(_tokenSeguridad))
            {
                return "Transacción rechazada: Token de seguridad inválido.";
            }
            return "Transacción base procesada exitosamente.";
        }
    }

}
