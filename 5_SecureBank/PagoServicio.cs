using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_SecureBank
{
    public class PagoServicio : Transaccion
    {
        public string Servicio { get; set; }
        public int DiasVencido { get; set; }
        public decimal MontoBase { get; set; }

        public override string Procesar()
        {
            string validacionBase = base.Procesar();
            if (validacionBase.Contains("rechazada"))
            {
                return validacionBase;
            }

            if (DiasVencido > 0)
            {
                decimal tasaInteres = 0.05m;
                decimal montoFinal = MontoBase * (decimal)Math.Pow((double)(1 + tasaInteres), DiasVencido);
                return $"Pago de {Servicio} procesado con recargo por {DiasVencido} días de vencimiento. Total final: ${Math.Round(montoFinal, 2)}";
            }

            return $"Pago de {Servicio} por ${MontoBase} procesado a tiempo.";
        }
    }
}
