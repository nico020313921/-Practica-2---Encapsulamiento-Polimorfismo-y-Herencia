using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MarketCraft
{
    public class ItemMercado
    {
        private string _nombre;
        private decimal _precioBase;
        private int _stock;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _nombre = value;
            }
        }

        public decimal PrecioBase
        {
            get { return _precioBase; }
            set
            {
                if (value >= 0)
                    _precioBase = value;
            }
        }

        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value >= 0)
                    _stock = value;
            }
        }

        public virtual string CotizarVenta(int cantidad)
        {
            if (Stock >= cantidad)
            {
                decimal total = PrecioBase * cantidad;
                Stock -= cantidad;
                return $"Venta de {cantidad} unidades de {Nombre} por un total de ${total}. Stock restante: {Stock}";
            }
            return $"No hay suficiente stock de {Nombre} para vender {cantidad} unidades. Stock actual: {Stock}";
        }
    }

}
