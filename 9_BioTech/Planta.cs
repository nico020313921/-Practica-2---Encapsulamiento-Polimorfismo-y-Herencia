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
    using System.Text;
    using System.Threading.Tasks;

    namespace _9_BioTech
    {
        public class Planta
        {
            private int _edadDias;
            private int _salud;

            public int EdadDias
            {
                get { return _edadDias; }
                set
                {
                    if (value >= 0)
                    {
                        _edadDias = value;
                    }
                }
            }

            public int Salud
            {
                get { return _salud; }
                set
                {
                    if (value < 0)
                    {
                        _salud = 0;
                    }
                    else if (value > 100)
                    {
                        _salud = 100;
                    }
                    else
                    {
                        _salud = value;
                    }
                }
            }

            public virtual string AplicarClima(string clima)
            {
                _edadDias++;
                return $"Clima {clima} aplicado a la planta. Edad: {_edadDias} días. Salud: {Salud}%";
            }
        }
    }
}
