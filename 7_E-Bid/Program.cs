using _7_E_Bid;
using _7_E_Bid._7_E_Bid;
using System;
using System.Collections.Generic;

namespace EBid
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Subasta> salaSubastas = new List<Subasta>();

            SubastaRelampago subastaRapida = new SubastaRelampago();
            subastaRapida.PrecioActual = 100;
            subastaRapida.TiempoRestanteSegundos = 8;

            SubastaPremium subastaVIP = new SubastaPremium();
            subastaVIP.PrecioActual = 500;
            subastaVIP.MontoMinimoIncremento = 50;

            salaSubastas.Add(subastaRapida);
            salaSubastas.Add(subastaVIP);

            decimal[] ofertasAIntentar = { 105, 600 };

            foreach (var oferta in ofertasAIntentar)
            {
                Console.WriteLine($"--- Ronda de Oferta: {oferta} ---");
                foreach (var subasta in salaSubastas)
                {
                    string resultado = subasta.RegistrarOferta(oferta);
                    Console.WriteLine(resultado);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}