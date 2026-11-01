using System;

namespace TP_Desenvolvimento_WEB
{
    public class RobustLogger
    {
        public Action<string> LogAction;

        public void LogToConsole(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[CONSOLE LOG] {message}");
            Console.ResetColor();
        }

        public void LogToFile(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[ARQUIVO LOG] Escrevendo no arquivo: {message}");
            Console.ResetColor();
        }

        public void ProcessLog(string message)
        {
            Console.WriteLine("A tentar invocar o delegate de log...");

            LogAction?.Invoke(message);

            Console.WriteLine("Invocação concluída com sucesso (sem exceções)!");
        }
    }

    public class Exercicio7
    {
        public static void Executar()
        {

            RobustLogger logger = new RobustLogger();

            Console.WriteLine("Cenário 1: Tentando disparar o delegate sem nenhum método associado (nulo)...");
            logger.ProcessLog("Tentativa de log com delegate vazio.");


            Console.WriteLine("Cenário 2: Adicionando métodos e disparando novamente...");
            logger.LogAction += logger.LogToConsole;
            logger.LogAction += logger.LogToFile;

            logger.ProcessLog("Mensagem de teste com métodos associados.");

            Console.WriteLine("\nProcesso do Exercício 7 finalizado com segurança.");
        }
    }
}