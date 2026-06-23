using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MarketCraft
{
    public class Pocion : ItemMercado
    {
        public override string CotizarVenta(int cantidad)
        {
            if (Stock >= cantidad)
            {
                decimal total = PrecioBase * cantidad;
                Stock -= cantidad;
                return $"Venta de {cantidad} unidades de {Nombre} por un total de ${total}. Stock restante: {Stock}";
            }
            else if (Stock > 0)
            {
                int remanente = Stock;
                decimal total = PrecioBase * remanente;
                Stock = 0;
                return $"Stock insuficiente. Solo se ofrecieron las {remanente} unidades remanentes de {Nombre} por un total de ${total}. Stock restante: {Stock}";
            }
            return $"No hay unidades disponibles de {Nombre}. Stock restante: {Stock}";
        }
    }
}
