using System;
using System.Globalization;

namespace TP_Desenvolvimento_WEB
{
    public class TemperatureEventArgs : EventArgs
    {
        public double CurrentTemperature { get; }

        public TemperatureEventArgs(double temperature)
        {
            CurrentTemperature = temperature;
        }
    }

    public class TemperatureSensor
    {
        public event EventHandler<TemperatureEventArgs> TemperatureExceeded;

        public void SimulateReading(double temperature)
        {
            Console.WriteLine($"[Sensor] Leitura efetuada: {temperature:F1}ºC");

            if (temperature > 100.0)
            {
                OnTemperatureExceeded(new TemperatureEventArgs(temperature));
            }
        }

        protected virtual void OnTemperatureExceeded(TemperatureEventArgs e)
        {
            TemperatureExceeded?.Invoke(this, e);
        }
    }

    public class Exercicio4
    {
        public static void Executar()
        {

            TemperatureSensor sensor = new TemperatureSensor();

            sensor.TemperatureExceeded += AlertaTemperaturaExcedida;

            Console.WriteLine("Simulando leituras de temperatura (digite 'sair' para encerrar):");

            while (true)
            {
                Console.Write("\nInforme o valor da temperatura lida (ºC): ");
                string entrada = Console.ReadLine();

                if (entrada != null && entrada.Trim().ToLower() == "sair")
                {
                    break;
                }

                if (double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out double temperatura))
                {
                    sensor.SimulateReading(temperatura);
                }
                else
                {
                    Console.WriteLine("Valor invalido. Digite um número váalido ou 'sair'.");
                }
            }

            sensor.TemperatureExceeded -= AlertaTemperaturaExcedida;
        }

        private static void AlertaTemperaturaExcedida(object sender, TemperatureEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n Temperatura limite ultrapassada: {e.CurrentTemperature:F1}ºC!");
            Console.ResetColor();
        }
    }
}