using _8_NetFetch;
using _8_NetFetch._8_NetFetch;
using System;
using System.Collections.Generic;

namespace NetFetch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Descarga> listaDescargas = new List<Descarga>();

            StreamingVideo video = new StreamingVideo();
            video.TamanoMegas = 500;
            video.BufferMinimo = 30;

            ArchivoComprimido zipSeguro = new ArchivoComprimido();
            zipSeguro.TamanoMegas = 200;
            zipSeguro.EsSeguro = true;

            ArchivoComprimido zipInfectado = new ArchivoComprimido();
            zipInfectado.TamanoMegas = 100;
            zipInfectado.EsSeguro = false;

            listaDescargas.Add(video);
            listaDescargas.Add(zipSeguro);
            listaDescargas.Add(zipInfectado);

            for (int paso = 1; paso <= 5; paso++)
            {
                Console.WriteLine($"--- Paso del tiempo: Segundo {paso} ---");
                foreach (var descarga in listaDescargas)
                {
                    string status = descarga.ActualizarProgreso(30);
                    Console.WriteLine(status);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
