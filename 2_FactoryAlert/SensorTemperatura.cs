using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FactoryAlert
{
    public class SensorTemperatura : Sensor
    {
        private double _limiteCritico;

        public double LimiteCritico
        {
            get { return _limiteCritico; }
            set { _limiteCritico = value; }
        }

        public override string EvaluarLectura(double valor)
        {
            if (valor > _limiteCritico)
            {
                Estado = "Peligro";
                string reporte = $"SENSOR TEMPERATURA {Id} - CRÍTICO: {valor} - ESTADO: {Estado}";
                return reporte.ToUpper();
            }

            return $"Sensor Temperatura {Id} - Lectura: {valor} - Estado: {Estado}";
        }
    }

}
