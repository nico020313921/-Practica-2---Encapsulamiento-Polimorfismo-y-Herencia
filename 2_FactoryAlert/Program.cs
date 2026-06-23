using _2_FactoryAlert;
using System;
using System.Collections.Generic;

namespace FactoryAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sensor> listaSensores = new List<Sensor>();

            SensorTemperatura temp1 = new SensorTemperatura { Id = "T-01", Estado = "Ok", LimiteCritico = 85.0 };
            SensorPresion pres1 = new SensorPresion { Id = "P-01", Estado = "Ok" };

            listaSensores.Add(temp1);
            listaSensores.Add(pres1);

            Console.WriteLine("--- Primera Ronda de Lecturas (Valores Normales) ---");
            Console.WriteLine(temp1.EvaluarLectura(70.0));
            Console.WriteLine(pres1.EvaluarLectura(30.0));
            Console.WriteLine(pres1.EvaluarLectura(35.0));

            Console.WriteLine("\n--- Segunda Ronda de Lecturas (Simulación Crítica) ---");

            double lecturaCriticaTemp = 90.0;
            double lecturaCriticaPres = 42.0;

            foreach (var sensor in listaSensores)
            {
                if (sensor is SensorTemperatura)
                {
                    Console.WriteLine(sensor.EvaluarLectura(lecturaCriticaTemp));
                }
                else if (sensor is SensorPresion)
                {
                    Console.WriteLine(sensor.EvaluarLectura(lecturaCriticaPres));
                }
            }

            Console.ReadLine();
        }
    }
}