using _10_CryptoCore;
using System;
using System.Collections.Generic;

namespace CryptoCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Sistema de Cifrado CryptoCore --- \n");

            string textoAProcesar = "Programacion C Sharp";

            // Creamos la lista polimórfica que acepta cualquier hijo de Mensaje
            List<Mensaje> panelCifrados = new List<Mensaje>();

            // Instancia 1: Cifrado Invertido
            panelCifrados.Add(new CifradoInvertido { TextoOriginal = textoAProcesar });

            // Instancia 2: Cifrado por Desplazamiento (Clave: 3)
            panelCifrados.Add(new CifradoDesplazamiento { TextoOriginal = textoAProcesar, ClaveNumerica = 3 });

            Console.WriteLine($"Texto Original: {textoAProcesar}");
            Console.WriteLine("--------------------------------------------");

            // Recorremos la lista polimórficamente
            foreach (var mensaje in panelCifrados)
            {
                // El programa no sabe qué tipo exacto es, solo sabe que es un 'Mensaje'
                // Pero gracias al 'override', cada objeto sabe cómo cifrarse.
                Console.WriteLine($"Tipo de Cifrado: {mensaje.GetType().Name}");
                Console.WriteLine($"Resultado:       {mensaje.Cifrar()}");
                Console.WriteLine("--------------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
