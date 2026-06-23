using _9_BioTech;
using _9_BioTech._9_BioTech;
using System;
using System.Collections.Generic;

namespace BioTech
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planta> invernadero = new List<Planta>();

            Cactus cactusDesierto = new Cactus();
            cactusDesierto.EdadDias = 10;
            cactusDesierto.Salud = 80;

            Helecho helechoBosque = new Helecho();
            helechoBosque.EdadDias = 5;
            helechoBosque.Salud = 90;
            helechoBosque.HumedadRequerida = 75;

            invernadero.Add(cactusDesierto);
            invernadero.Add(helechoBosque);

            string[] ciclosClimaticos = { "Seco", "Desértico", "Lluvioso" };

            foreach (var clima in ciclosClimaticos)
            {
                Console.WriteLine($"=== CAMBIO CLIMÁTICO DETECTADO: {clima.ToUpper()} ===");
                foreach (var planta in invernadero)
                {
                    string reporte = planta.AplicarClima(clima);
                    Console.WriteLine(reporte);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}