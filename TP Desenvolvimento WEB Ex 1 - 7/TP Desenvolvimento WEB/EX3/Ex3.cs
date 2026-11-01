using System;
using System.Globalization;

namespace TP_Desenvolvimento_WEB
{
    public class Exercicio3
    {
        public static void Executar()
        {

            Console.Write("Informe a base do retângulo: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double baseRetangulo))
            {
                Console.Write("Informe a altura do retângulo: ");
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double alturaRetangulo))
                {
                    Func<double, double, double> calcularArea = (b, h) => b * h;
                    double areaFinal = calcularArea(baseRetangulo, alturaRetangulo);

                    Console.WriteLine($"\narea do retangulo calculada: {areaFinal:F2}");
                }
                else
                {
                    Console.WriteLine("Altura invalida informada.");
                }
            }
            else
            {
                Console.WriteLine("base invalida informada.");
            }
        }
    }
}