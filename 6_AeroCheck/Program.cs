using _6_AeroCheck;
using System;
using System.Collections.Generic;

namespace AeroCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aeronave> inventarioAereo = new List<Aeronave>();

            AvionComercial avion1 = new AvionComercial();
            avion1.HorasVuelo = 12500;
            avion1.PasajerosMaximos = 180;

            AvionComercial avion2 = new AvionComercial();
            avion2.HorasVuelo = 4500;
            avion2.PasajerosMaximos = 120;

            Helicoptero heli1 = new Helicoptero();
            heli1.HorasVuelo = 300;
            heli1.CiclosRotor = 200;

            Helicoptero heli2 = new Helicoptero();
            heli2.HorasVuelo = 150;
            heli2.CiclosRotor = 400;

            inventarioAereo.Add(avion1);
            inventarioAereo.Add(avion2);
            inventarioAereo.Add(heli1);
            inventarioAereo.Add(heli2);

            Console.WriteLine("--- REPORTE GENERAL DE MANTENIMIENTO ---");
            foreach (var aeronave in inventarioAereo)
            {
                Console.WriteLine($"Horas de Vuelo: {aeronave.HorasVuelo}");
                Console.WriteLine(aeronave.GenerarReporteMantenimiento());
                Console.WriteLine("---------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
