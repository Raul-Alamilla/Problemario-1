using System;
class Program
{
    static void Main()
    {
        // Encabezado del ejercicio
        Console.WriteLine("EJERCICIO 5");
        Console.WriteLine("Análisis de vibración de varios motores (while).");
        Console.WriteLine("Para cada motor: nombre, 4 mediciones (for), promedio, clasificación");
        Console.WriteLine("(<= 4.5 mm/s: NORMAL, > 4.5 mm/s: MANTENIMIENTO) y preguntar si desea otro.");
        Console.WriteLine("Al finalizar: total evaluados, normales y que requieren mantenimiento.");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        char respuesta = 's';
        int totalMotores = 0;
        int normales = 0;
        int mantenimiento = 0;

        while (respuesta == 's')
        {
            Console.Write("Ingrese el nombre o identificador del motor: ");
            string motor = Console.ReadLine();
            double suma = 0;

            // Solicitar 4 mediciones de vibración
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Ingrese la vibración " + i + " (mm/s): ");
                double vibracion = double.Parse(Console.ReadLine());
                suma = suma + vibracion;
            }

            double promedio = suma / 4;
            totalMotores++;
            Console.WriteLine("Motor: " + motor);
            Console.WriteLine("Vibración promedio: " + promedio + " mm/s");

            if (promedio <= 4.5)
            {
                Console.WriteLine("FUNCIONAMIENTO NORMAL DEL MOTOR");
                normales++;
            }
            else
            {
                Console.WriteLine("EL MOTOR REQUIERE MANTENIMIENTO");
                mantenimiento++;
            }

            Console.WriteLine();
            Console.Write("¿Desea analizar otro motor? (s/n): ");
            respuesta = char.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }

        Console.WriteLine("TOTAL DE MOTORES EVALUADOS: " + totalMotores);
        Console.WriteLine("MOTORES CON FUNCIONAMIENTO NORMAL: " + normales);
        Console.WriteLine("MOTORES QUE REQUIEREN MANTENIMIENTO: " + mantenimiento);
    }
}