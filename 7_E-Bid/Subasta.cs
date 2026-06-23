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
        public class Subasta
        {
            private decimal _precioActual;

            public decimal PrecioActual
            {
                get { return _precioActual; }
                set
                {
                    if (value >= 0)
                    {
                        _precioActual = value;
                    }
                }
            }

            public virtual string RegistrarOferta(decimal oferta)
            {
                if (oferta > _precioActual)
                {
                    _precioActual = oferta;
                    return $"Oferta aceptada. El nuevo precio base es {_precioActual}.";
                }
                return "Oferta rechazada. El monto debe ser mayor al precio actual.";
            }
        }
    }
}
