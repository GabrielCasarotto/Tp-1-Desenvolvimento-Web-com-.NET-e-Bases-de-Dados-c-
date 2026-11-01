using System;

namespace TP_Desenvolvimento_WEB
{
    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"console log:  {message}");
            Console.ResetColor();
        }

        public void LogToFile(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Escrevendo no arquivo 'sistema.log': {message}");
            Console.ResetColor();
        }

        public void LogToDatabase(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Inserindo log na tabela Logs: '{message}'");
            Console.ResetColor();
        }
    }

    public class Exercicio6
    {
        public static void Executar()
        {

            Logger loggerInstance = new Logger();

            Action<string> logDelegate = loggerInstance.LogToConsole;
            logDelegate += loggerInstance.LogToFile;
            logDelegate += loggerInstance.LogToDatabase;

            Console.Write("Digite a mensagem de log que deseja registrar: ");
            string mensagemUsuario = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(mensagemUsuario))
            {
                mensagemUsuario = "Sistema inicializado com sucesso.";
            }

            Console.WriteLine("\nExecutando o Multicast Delegate (disparando todos os destinos):\n");

            logDelegate(mensagemUsuario);

            Console.WriteLine("\nProcesso de logging finalizado para todos os destinos.");
        }
    }
}