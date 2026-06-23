using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MarketCraft
{
    public class MineralRaro : ItemMercado
    {
        private decimal _factorEscasez;

        public decimal FactorEscasez
        {
            get { return _factorEscasez; }
            set
            {
                if (value >= 1)
                    _factorEscasez = value;
            }
        }

        public override string CotizarVenta(int cantidad)
        {
            if (Stock >= cantidad)
            {
                decimal total = PrecioBase * cantidad;
                Stock -= cantidad;

                if (Stock < 5)
                {
                    total *= FactorEscasez;
                    return $"¡Precio inflado por alta demanda! Venta de {cantidad} unidades de {Nombre} por un total de ${total}. Stock restante: {Stock}";
                }

                return $"Venta de {cantidad} unidades de {Nombre} por un total de ${total}. Stock restante: {Stock}";
            }
            return $"No hay suficiente stock de {Nombre} para vender {cantidad} unidades. Stock actual: {Stock}";
        }
    }

}
