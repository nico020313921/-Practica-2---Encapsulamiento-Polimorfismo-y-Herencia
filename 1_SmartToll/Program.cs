using _1_SmartToll;
using System;
using System.Collections.Generic;

namespace SmartToll
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tarifaBase = 100m;

            List<Vehiculo> peaje = new List<Vehiculo>();

            peaje.Add(new Particular { Patente = "ABC123", Saldo = 150m });
            peaje.Add(new Particular { Patente = "XYZ789", Saldo = 50m });
            peaje.Add(new Camion { Patente = "CAM002", Saldo = 500m, Ejes = 2 });
            peaje.Add(new Camion { Patente = "CAM005", Saldo = 400m, Ejes = 5 });
            peaje.Add(new Camion { Patente = "CAM009", Saldo = 200m, Ejes = 6 });

            Console.WriteLine("--- Reporte de Peaje SmartToll ---");
            foreach (var vehiculo in peaje)
            {
                string resultado = vehiculo.PagarPeaje(tarifaBase);
                Console.WriteLine(resultado);
            }

            Console.ReadLine();
        }
    }
}