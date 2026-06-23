using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AeroCheck
{
    public class Aeronave
    {
        private int _horasVuelo;

        public int HorasVuelo
        {
            get { return _horasVuelo; }
            set
            {
                if (value >= 0)
                {
                    _horasVuelo = value;
                }
            }
        }

        public virtual string GenerarReporteMantenimiento()
        {
            return "Reporte base: Mantenimiento de rutina general requerido.";
        }
    }
}
