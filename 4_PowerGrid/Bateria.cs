using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4_PowerGrid
{
    public class Bateria
    {
        private int _porcentajeCarga;

        public int PorcentajeCarga
        {
            get { return _porcentajeCarga; }
            set
            {
                if (value >= 0 && value <= 100)
                    _porcentajeCarga = value;
            }
        }

        public virtual string ConsumirEnergia(int puntos)
        {
            if (PorcentajeCarga >= puntos)
            {
                PorcentajeCarga -= puntos;
                return $"Consumo base de {puntos} puntos realizado. Carga actual: {PorcentajeCarga}%";
            }
            return $"Energía insuficiente. Carga actual: {PorcentajeCarga}%";
        }
    }
}
