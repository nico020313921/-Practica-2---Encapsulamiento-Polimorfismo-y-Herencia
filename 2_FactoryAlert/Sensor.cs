using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FactoryAlert
{
    public class Sensor
    {
        private string _id;
        private string _estado;

        public string Id
        {
            get { return _id; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _id = value;
            }
        }

        public string Estado
        {
            get { return _estado; }
            set
            {
                if (value == "Ok" || value == "Alerta" || value == "Peligro")
                    _estado = value;
            }
        }

        public virtual string EvaluarLectura(double valor)
        {
            return $"Sensor {Id} - Lectura: {valor} - Estado: {Estado}";
        }
    }

}
