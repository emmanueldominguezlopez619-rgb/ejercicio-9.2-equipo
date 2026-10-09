using System;

namespace P2_PA_IM_26B
{
    // Clase que representa una bomba eléctrica
    public class BombaElectrica
    {
        // Propiedades de la clase
        public string Identificador { get; set; }
        public double Voltaje { get; set; }
        public double Corriente { get; set; }
        public double Caudal { get; set; }

        // Método para calcular la potencia eléctrica P = V * I
        public double CalcularPotencia()
        {
            return Voltaje * Corriente;
        }

        // Método para calcular el indicador de desempeño (Caudal / Potencia)
        public double CalcularIndicadorDesempeno()
        {
            double potencia = CalcularPotencia();
            if (potencia == 0) return 0; // Evitar división por cero
            return Caudal / potencia;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creación de objetos para la bomba 1 y bomba 2
            BombaElectrica bomba1 = new BombaElectrica();
            BombaElectrica bomba2 = new BombaElectrica();

            Console.WriteLine("--- EVALUACIÓN DE BOMBAS ELÉCTRICAS ---");

            // Captura de datos para la Bomba 1
            Console.WriteLine("\nIngrese datos de la Bomba 1:");
            Console.Write("Identificador: ");
            bomba1.Identificador = Console.ReadLine();
            Console.Write("Voltaje (V): ");
            bomba1.Voltaje = Convert.ToDouble(Console.ReadLine());
            Console.Write("Corriente (A): ");
            bomba1.Corriente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Caudal (L/min): ");
            bomba1.Caudal = Convert.ToDouble(Console.ReadLine());

            // Captura de datos para la Bomba 2
            Console.WriteLine("\nIngrese datos de la Bomba 2:");
            Console.Write("Identificador: ");
            bomba2.Identificador = Console.ReadLine();
            Console.Write("Voltaje (V): ");
            bomba2.Voltaje = Convert.ToDouble(Console.ReadLine());
            Console.Write("Corriente (A): ");
            bomba2.Corriente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Caudal (L/min): ");
            bomba2.Caudal = Convert.ToDouble(Console.ReadLine());

            // Cálculos y resultados
            double p1 = bomba1.CalcularPotencia();
            double ind1 = bomba1.CalcularIndicadorDesempeno();
            double p2 = bomba2.CalcularPotencia();
            double ind2 = bomba2.CalcularIndicadorDesempeno();

            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine($"Bomba [{bomba1.Identificador}] -> Potencia: {p1:F2} W | Desempeño: {ind1:F4} (L/min)/W");
            Console.WriteLine($"Bomba [{bomba2.Identificador}] -> Potencia: {p2:F2} W | Desempeño: {ind2:F4} (L/min)/W");

            // Comparación de desempeño
            if (ind1 > ind2)
            {
                Console.WriteLine($"\nResultado: La bomba {bomba1.Identificador} entrega más caudal por watt.");
            }
            else if (ind2 > ind1)
            {
                Console.WriteLine($"\nResultado: La bomba {bomba2.Identificador} entrega más caudal por watt.");
            }
            else
            {
                Console.WriteLine("\nResultado: Existe un empate en el desempeño de ambas bombas.");
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}