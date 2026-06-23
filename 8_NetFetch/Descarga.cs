using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_NetFetch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _8_NetFetch
    {
        public class Descarga
        {
            private int _tamanoMegas;
            private int _progreso;

            public int TamanoMegas
            {
                get { return _tamanoMegas; }
                set
                {
                    if (value >= 0)
                    {
                        _tamanoMegas = value;
                    }
                }
            }

            public int Progreso
            {
                get { return _progreso; }
                set
                {
                    if (value >= 0 && value <= 100)
                    {
                        _progreso = value;
                    }
                }
            }

            public virtual string ActualizarProgreso(int megasDescargados)
            {
                if (_tamanoMegas > 0)
                {
                    int nuevoProgreso = _progreso + (megasDescargados * 100 / _tamanoMegas);
                    Progreso = nuevoProgreso > 100 ? 100 : nuevoProgreso;
                }
                return $"Progreso general: {Progreso}%";
            }
        }
    }
}
