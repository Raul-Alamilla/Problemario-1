using System;

class Program
{
    static void Main()
    {
        // 6) El encabezado en la consola deberá mostrar el planteamiento del problema [cite: 2].
        Console.WriteLine("Ejercicio 2");
        Console.WriteLine("PROBLEMA: TEMPERATURA PROMEDIO DE UN MOTOR");
        Console.WriteLine();

        double suma = 0;

        // Solicitar las 10 mediciones
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese la temperatura " + i + ": ");
            double temperatura = double.Parse(Console.ReadLine());
            suma = suma + temperatura;
        }
        Console.WriteLine();
        // Calcular promedio
        double promedio = suma / 10;
        Console.WriteLine("Temperatura promedio: " + promedio + " °C");

        Console.WriteLine();

        if (promedio <= 70)
        {
            Console.WriteLine("TEMPERATURA NORMAL");
        }
        else
        {
            Console.WriteLine("ALERTA DE TEMPERATURA");
        }
    }
}