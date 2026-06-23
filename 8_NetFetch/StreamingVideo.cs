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
        public class StreamingVideo : Descarga
        {
            private int _bufferMinimo;

            public int BufferMinimo
            {
                get { return _bufferMinimo; }
                set
                {
                    if (value >= 0 && value <= 100)
                    {
                        _bufferMinimo = value;
                    }
                }
            }

            public override string ActualizarProgreso(int megasDescargados)
            {
                base.ActualizarProgreso(megasDescargados);

                if (Progreso < _bufferMinimo)
                {
                    return $"Cargando... Video pausado ({Progreso}% de {_bufferMinimo}% requerido)";
                }
                return $"Reproduciendo video... Progreso de descarga: {Progreso}%";
            }
        }
    }
}
