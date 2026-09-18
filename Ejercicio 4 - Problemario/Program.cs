using System;
class Program
{
    static void Main()
    {
        // Encabezado del ejercicio
        Console.WriteLine("EJERCICIO 4");
        Console.WriteLine("8 mediciones de corriente de un actuador eléctrico.");
        Console.WriteLine("<= 5 A: MEDICIÓN NORMAL | > 5 A: SOBRECORRIENTE DETECTADA.");
        Console.WriteLine("Al finalizar muestra promedio, normales, sobrecorrientes y resultado general:");
        Console.WriteLine("ACTUADOR APROBADO (0 sobrecorrientes) o REQUIERE REVISIÓN.");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        double suma = 0;
        int normales = 0;
        int sobrecorrientes = 0;

        // Solicitar las 8 mediciones
        for (int i = 1; i <= 8; i++)
        {
            Console.Write("Ingrese la corriente " + i + ": ");
            double corriente = double.Parse(Console.ReadLine());
            suma = suma + corriente;
            if (corriente <= 5)
            {
                Console.WriteLine("MEDICIÓN NORMAL");
                normales++;
            }
            else
            {
                Console.WriteLine("SOBRECORRIENTE DETECTADA");
                sobrecorrientes++;
            }
        }

        double promedio = suma / 8;
        Console.WriteLine();
        Console.WriteLine("Corriente promedio: " + promedio + " A");
        Console.WriteLine("Mediciones normales: " + normales);
        Console.WriteLine("Sobrecorrientes: " + sobrecorrientes);

        Console.WriteLine();
        if (sobrecorrientes == 0)
        {
            Console.WriteLine("ACTUADOR APROBADO");
        }
        else
        {
            Console.WriteLine("EL ACTUADOR REQUIERE REVISIÓN");
        }
    }
}