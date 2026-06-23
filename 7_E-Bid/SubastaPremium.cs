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
        public class SubastaPremium : Subasta
        {
            private decimal _montoMinimoIncremento;

            public decimal MontoMinimoIncremento
            {
                get { return _montoMinimoIncremento; }
                set
                {
                    if (value >= 0)
                    {
                        _montoMinimoIncremento = value;
                    }
                }
            }

            public override string RegistrarOferta(decimal oferta)
            {
                if (oferta >= (PrecioActual + _montoMinimoIncremento))
                {
                    PrecioActual = oferta;
                    return $"Oferta Premium aceptada. El nuevo precio es {PrecioActual}.";
                }
                return $"Oferta Premium rechazada. No supera el incremento mínimo requerido de {_montoMinimoIncremento} sobre el precio actual de {PrecioActual}.";
            }
        }
    }
}
