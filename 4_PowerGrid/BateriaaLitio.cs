using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PowerGrid
{
    public class BateriaLitio : Bateria
    {
        private bool _modoAhorroActivo = false;

        public override string ConsumirEnergia(int puntos)
        {
            int puntosAConsumir = puntos;

            if (_modoAhorroActivo)
            {
                puntosAConsumir = puntos / 2;
            }

            if (PorcentajeCarga >= puntosAConsumir)
            {
                PorcentajeCarga -= puntosAConsumir;

                if (PorcentajeCarga == 0 && !_modoAhorroActivo)
                {
                    _modoAhorroActivo = true;
                    return $"Consumo de {puntosAConsumir} puntos realizado. ¡Batería agotada! Se activa el modo Ahorro de Energía para la próxima ronda. Carga actual: {PorcentajeCarga}%";
                }

                if (_modoAhorroActivo)
                {
                    return $"Consumo reducido a la mitad ({puntosAConsumir} puntos) por Modo Ahorro. Carga actual: {PorcentajeCarga}%";
                }

                return $"Consumo de {puntosAConsumir} puntos realizado. Carga actual: {PorcentajeCarga}%";
            }

            return $"Energía insuficiente en Batería de Litio. Carga actual: {PorcentajeCarga}%";
        }
    }

}
