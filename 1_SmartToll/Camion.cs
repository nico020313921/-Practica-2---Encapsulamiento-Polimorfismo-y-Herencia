using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SmartToll
{
    public class Camion : Vehiculo
    {
        private int _ejes;

        public int Ejes
        {
            get { return _ejes; }
            set
            {
                if (value > 0)
                    _ejes = value;
            }
        }

        public override string PagarPeaje(decimal tarifa)
        {
            decimal tarifaTotal = tarifa * Ejes;

            if (Ejes > 4)
            {
                tarifaTotal *= 0.90m;
            }

            if (Saldo >= tarifaTotal)
            {
                Saldo -= tarifaTotal;
                return $"Camión {Patente} ({Ejes} ejes) pagó {tarifaTotal}. Pasaje permitido.";
            }
            return "Paso denegado";
        }
    }

}
