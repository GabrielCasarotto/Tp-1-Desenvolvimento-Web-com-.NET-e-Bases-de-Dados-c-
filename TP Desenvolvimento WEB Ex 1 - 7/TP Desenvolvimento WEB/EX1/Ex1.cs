using System;
using System.Globalization;

namespace TP_Desenvolvimento_WEB
{
    public class Exercicio1
    {
        public delegate decimal CalculateDiscount(decimal price);

        public static void Executar()
        {

            Console.Write("Informe o preço original: ");

            if (decimal.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal preco))
            {
                CalculateDiscount desconto = ApplyTenPercentDiscount;
                Console.WriteLine($"Valor final com 10% de desconto: R$ {desconto(preco):F2}");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }

        public static decimal ApplyTenPercentDiscount(decimal price) => price * 0.90m;
    }
}