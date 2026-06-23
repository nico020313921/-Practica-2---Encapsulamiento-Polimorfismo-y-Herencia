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
        public class Cactus : Planta
        {
            public override string AplicarClima(string clima)
            {
                base.AplicarClima(clima);

                if (clima == "Lluvioso")
                {
                    Salud -= 30;
                    return $"Cactus sufriendo por exceso de agua. Se está ahogando. Salud actual: {Salud}%";
                }
                if (clima == "Desértico")
                {
                    Salud += 20;
                    return $"Cactus en su hábitat óptimo. Salud actual: {Salud}%";
                }
                return $"Cactus expuesto a clima {clima}. Salud actual: {Salud}%";
            }
        }
    }
}
