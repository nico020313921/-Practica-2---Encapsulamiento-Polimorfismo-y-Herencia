using _3_MarketCraft;
using System;
using System.Collections.Generic;

namespace MarketCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ItemMercado> inventario = new List<ItemMercado>();

            inventario.Add(new ItemMercado { Nombre = "Flecha Común", PrecioBase = 5m, Stock = 20 });
            inventario.Add(new Pocion { Nombre = "Poción de Vida", PrecioBase = 50m, Stock = 7 });
            inventario.Add(new MineralRaro { Nombre = "Mithril", PrecioBase = 500m, Stock = 12, FactorEscasez = 1.5m });

            Console.WriteLine("--- Simulación de Compra en MarketCraft (10 unidades por ítem) ---");

            int cantidadCompra = 10;

            foreach (var item in inventario)
            {
                string resultado = item.CotizarVenta(cantidadCompra);
                Console.WriteLine(resultado);
            }

            Console.ReadLine();
        }
    }
}
