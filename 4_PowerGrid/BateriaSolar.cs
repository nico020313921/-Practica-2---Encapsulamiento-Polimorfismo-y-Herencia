using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PowerGrid
{
    public class BateriaSolar : Bateria
    {
        private double _eficienciaPanel;

        public double EficienciaPanel
        {
            get { return _eficienciaPanel; }
            set
            {
                if (value >= 0 && value <= 1)
                    _eficienciaPanel = value;
            }
        }

        public override string ConsumirEnergia(int puntos)
        {
            if (PorcentajeCarga >= puntos)
            {
                PorcentajeCarga -= puntos;

                int recuperacion = (int)(puntos * EficienciaPanel);
                PorcentajeCarga += recuperacion;

                if (PorcentajeCarga > 100)
                {
                    PorcentajeCarga = 100;
                }

                int gastoNeto = puntos - recuperacion;
                return $"Consumo bruto: {puntos} puntos. Recuperación solar: {recuperacion} puntos. Gasto neto real: {gastoNeto} puntos. Carga actual: {PorcentajeCarga}%";
            }

            return $"Energía insuficiente en Batería Solar. Carga actual: {PorcentajeCarga}%";
        }
    }

}
