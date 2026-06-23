using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_SecureBank
{
    public class Transferencia : Transaccion
    {
        public decimal Monto { get; set; }
        public string CuentaDestino { get; set; }

        public override string Procesar()
        {
            string validacionBase = base.Procesar();
            if (validacionBase.Contains("rechazada"))
            {
                return validacionBase;
            }

            if (Monto > 500000)
            {
                return "Requiere autorización presencial";
            }

            return $"Transferencia de ${Monto} a la cuenta {CuentaDestino} procesada correctamente.";
        }
    }
}
