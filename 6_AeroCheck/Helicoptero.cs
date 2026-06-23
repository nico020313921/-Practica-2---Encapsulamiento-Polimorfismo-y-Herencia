using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AeroCheck
{
    public class Helicoptero : Aeronave
    {
        private int _ciclosRotor;

        public int CiclosRotor
        {
            get { return _ciclosRotor; }
            set
            {
                if (value >= 0)
                {
                    _ciclosRotor = value;
                }
            }
        }

        public override string GenerarReporteMantenimiento()
        {
            if ((HorasVuelo * _ciclosRotor) > 50000)
            {
                return "Helicóptero: Alerta: Reemplazo de palas requerido.";
            }
            return "Helicóptero: Rendimiento del rotor dentro del rango seguro.";
        }
    }
}