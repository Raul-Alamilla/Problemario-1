using System;
class Program
{
    static void Main()
    {
        // Encabezado del ejercicio
        Console.WriteLine("EJERCICIO 3");
        Console.WriteLine("Diseñe un programa que simule la carga de una batería de 12.6 V.");
        Console.WriteLine("El usuario ingresa voltaje inicial e incremento por ciclo.");
        Console.WriteLine("Mediante while, aumenta hasta 12.6 V mostrando ciclo y voltaje actual.");
        Console.WriteLine("Si incremento <= 0, mostrar mensaje de error y no ejecutar.");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        Console.Write("Ingrese el voltaje inicial: ");
        double voltaje = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el incremento de voltaje por ciclo: ");
        double incremento = double.Parse(Console.ReadLine());

        Console.WriteLine();
        if (incremento <= 0)
        {
            Console.WriteLine("ERROR: EL INCREMENTO DEBE SER MAYOR QUE CERO.");
        }
        else
        {
            int ciclo = 0;
            while (voltaje < 12.6)
            {
                ciclo++;
                voltaje = voltaje + incremento;
                if (voltaje > 12.6)
                {
                    voltaje = 12.6;
                }
                Console.WriteLine("Ciclo " + ciclo + ": " + voltaje + " V");
            }
            Console.WriteLine("Batería cargada a 12.6 V.");
        }
    }
}