using _4_PowerGrid;
using System;
using System.Collections.Generic;

namespace PowerGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bateria> redBaterias = new List<Bateria>();

            BateriaLitio litio = new BateriaLitio { PorcentajeCarga = 30 };
            BateriaSolar solar = new BateriaSolar { PorcentajeCarga = 50, EficienciaPanel = 0.20 };

            redBaterias.Add(litio);
            redBaterias.Add(solar);

            int puntosConsumo = 30;

            for (int ronda = 1; ronda <= 3; ronda++)
            {
                Console.WriteLine($"--- Ronda {ronda} de Consumo ({puntosConsumo} puntos) ---");

                foreach (var bateria in redBaterias)
                {
                    string reporte = bateria.ConsumirEnergia(puntosConsumo);
                    Console.WriteLine(reporte);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}