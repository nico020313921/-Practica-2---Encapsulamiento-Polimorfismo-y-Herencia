using _5_SecureBank;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Transaccion> filaTransacciones = new List<Transaccion>();

        filaTransacciones.Add(new Transferencia
        {
            TokenSeguridad = "ABC12345",
            Monto = 150000,
            CuentaDestino = "987654321"
        });

        filaTransacciones.Add(new Transferencia
        {
            TokenSeguridad = "XYZ98765",
            Monto = 600000,
            CuentaDestino = "123456789"
        });

        filaTransacciones.Add(new PagoServicio
        {
            TokenSeguridad = "A1B2C3D4",
            Servicio = "Luz",
            DiasVencido = 3,
            MontoBase = 1000
        });

        filaTransacciones.Add(new PagoServicio
        {
            TokenSeguridad = "TOKENERR",
            Servicio = "Agua",
            DiasVencido = 0,
            MontoBase = 500
        });

        filaTransacciones.Add(new Transferencia
        {
            TokenSeguridad = "CORRECTO",
            Monto = 50000,
            CuentaDestino = "555555555"
        });

        Console.WriteLine("--- Procesando Transacciones Bancarias ---");
        foreach (var transaccion in filaTransacciones)
        {
            string resultado = transaccion.Procesar();
            Console.WriteLine($"Resultado: {resultado}");
        }

        Console.ReadLine();
    }
}