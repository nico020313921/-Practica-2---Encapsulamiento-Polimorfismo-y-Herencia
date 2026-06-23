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
        public class ArchivoComprimido : Descarga
        {
            private bool _esSeguro;

            public bool EsSeguro
            {
                get { return _esSeguro; }
                set { _esSeguro = value; }
            }

            public override string ActualizarProgreso(int megasDescargados)
            {
                base.ActualizarProgreso(megasDescargados);

                if (Progreso == 100 && !_esSeguro)
                {
                    Progreso = 0;
                    return "Descarga abortada por amenaza detectada";
                }
                return $"Descargando archivo comprimido: {Progreso}%";
            }
        }
    }
}
