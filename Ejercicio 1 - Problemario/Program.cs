using System;
class Program
{
    static void Main()
    {
        // Encabezado del ejercicio
        Console.WriteLine("EJERCICIO 1");
        Console.WriteLine("Diseñe un programa que solicite al usuario el voltaje");
        Console.WriteLine("y la corriente consumida por un motor de corriente directa.");
        Console.WriteLine("El programa deberá calcular la potencia eléctrica mediante:");
        Console.WriteLine("P = V * I");
        Console.WriteLine("Si la potencia es menor o igual a 120 W:");
        Console.WriteLine("CONSUMO NORMAL");
        Console.WriteLine("Si la potencia es mayor que 120 W:");
        Console.WriteLine("ADVERTENCIA: CONSUMO ELEVADO");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        // Solicitar el voltaje
        Console.Write("Ingrese el voltaje: ");
        double voltaje = double.Parse(Console.ReadLine());

        // Solicitar la corriente
        Console.Write("Ingrese la corriente: ");
        double corriente = double.Parse(Console.ReadLine());

        // Calcular la potencia
        double potencia = voltaje * corriente;

        // Mostrar la potencia
        Console.WriteLine("Potencia: " + potencia + " W");

        Console.WriteLine();
        // Clasificar el consumo
        if (potencia <= 120)
        {
            Console.WriteLine("CONSUMO NORMAL");
        }
        else
        {
            Console.WriteLine("ADVERTENCIA: CONSUMO ELEVADO");
        }
    }
}