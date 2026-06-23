using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_BioTech
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    namespace _9_BioTech
    {
        public class Helecho : Planta
        {
            private int _humedadRequerida;

            public int HumedadRequerida
            {
                get { return _humedadRequerida; }
                set
                {
                    if (value >= 0)
                    {
                        _humedadRequerida = value;
                    }
                }
            }

            public override string AplicarClima(string clima)
            {
                base.AplicarClima(clima);

                if (clima == "Seco")
                {
                    Salud -= 20;
                    return $"Helecho en peligro. Requiere riego urgente (Humedad requerida: {_humedadRequerida}%). Salud actual: {Salud}%";
                }
                if (clima == "Lluvioso")
                {
                    Salud += 15;
                    return $"Helecho absorbiendo humedad. Salud actual: {Salud}%";
                }
                return $"Helecho expuesto a clima {clima}. Salud actual: {Salud}%";
            }
        }
    }
}
