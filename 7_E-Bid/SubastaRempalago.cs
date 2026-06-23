using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_E_Bid
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _7_E_Bid
    {
        public class SubastaRelampago : Subasta
        {
            private int _tiempoRestanteSegundos;

            public int TiempoRestanteSegundos
            {
                get { return _tiempoRestanteSegundos; }
                set
                {
                    if (value >= 0)
                    {
                        _tiempoRestanteSegundos = value;
                    }
                }
            }

            public override string RegistrarOferta(decimal oferta)
            {
                if (oferta > PrecioActual)
                {
                    PrecioActual = oferta;
                    if (_tiempoRestanteSegundos < 10)
                    {
                        _tiempoRestanteSegundos += 30;
                        return $"¡Oferta de último segundo! Tiempo extendido. Nuevo precio: {PrecioActual}. Tiempo actual: {_tiempoRestanteSegundos}s.";
                    }
                    return $"Oferta aceptada en Subasta Relámpago. Nuevo precio: {PrecioActual}.";
                }
                return "Oferta rechazada en Subasta Relámpago por monto insuficiente.";
            }
        }
    }
}
