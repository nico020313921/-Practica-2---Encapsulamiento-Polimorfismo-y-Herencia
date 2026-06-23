using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SmartToll
{
    public class Vehiculo
    {
        private string _patente;
        private decimal _saldo;

        public string Patente
        {
            get { return _patente; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _patente = value;
            }
        }

        public decimal Saldo
        {
            get { return _saldo; }
            set
            {
                if (value >= 0)
                    _saldo = value;
            }
        }

        public virtual string PagarPeaje(decimal tarifa)
        {
            if (Saldo >= tarifa)
            {
                Saldo -= tarifa;
                return $"Vehículo {_patente} pagó {tarifa}. Pasaje permitido.";
            }
            return "Paso denegado";
        }
    }
}