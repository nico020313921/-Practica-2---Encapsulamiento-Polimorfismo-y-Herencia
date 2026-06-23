
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _6_AeroCheck
    {
        public class AvionComercial : Aeronave
        {
            private int _pasajerosMaximos;

            public int PasajerosMaximos
            {
                get { return _pasajerosMaximos; }
                set
                {
                    if (value >= 0)
                    {
                        _pasajerosMaximos = value;
                    }
                }
            }

            public override string GenerarReporteMantenimiento()
            {
                if (HorasVuelo > 10000)
                {
                    return $"Avión Comercial ({PasajerosMaximos} pasajeros): Revisión de Turbinas Tipo A obligatoria.";
                }
                return $"Avión Comercial ({PasajerosMaximos} pasajeros): Estado estable, chequeo estándar.";
            }
        }
    }

