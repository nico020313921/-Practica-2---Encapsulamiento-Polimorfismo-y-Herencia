using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FactoryAlert
{
    public class SensorPresion : Sensor
    {
        private List<double> _historialLecturas = new List<double>();

        public List<double> HistorialLecturas
        {
            get { return _historialLecturas; }
            set { _historialLecturas = value; }
        }

        public override string EvaluarLectura(double valor)
        {
            _historialLecturas.Add(valor);

            int total = _historialLecturas.Count;
            if (total >= 3)
            {
                double ultima = _historialLecturas[total - 1];
                double penultima = _historialLecturas[total - 2];
                double antepenultima = _historialLecturas[total - 3];

                if (ultima > penultima && penultima > antepenultima)
                {
                    Estado = "Alerta";
                    return $"Sensor Presión {Id} - Lectura: {valor} - Tendencia inestable - Estado: {Estado}";
                }
            }

            return $"Sensor Presión {Id} - Lectura: {valor} - Estado: {Estado}";
        }
    }

}
