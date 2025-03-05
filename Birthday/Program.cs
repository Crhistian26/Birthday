using System.Diagnostics.Tracing;
using System.Globalization;

namespace Birthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            do
            {
                DateTime fecha;
                Console.WriteLine("Ingresa el año en el que naciste: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa el mes en el que naciste: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ingresa el día del mes: ");
                int day = Convert.ToInt32(Console.ReadLine());
                try
                {
                    fecha = new DateTime(year, month, day);
                }
                catch (Exception e)
                {
                    Console.WriteLine("La fecha ingresada no es válida");
                    Console.ReadKey();
                    continue;
                }

                string dia = fecha.ToString("dddd", new CultureInfo("es-ES"));
                Console.WriteLine("Ese dia de la semana era: " + dia);
                continuar = false;
            } while (continuar);
        }
    }
}
