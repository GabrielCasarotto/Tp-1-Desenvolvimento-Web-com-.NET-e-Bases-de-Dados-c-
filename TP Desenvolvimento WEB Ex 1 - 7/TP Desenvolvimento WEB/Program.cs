using System;

namespace TP_Desenvolvimento_WEB
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu Exercicios ");
                Console.WriteLine("1 - Implementação de Delegate Personalizado para Descontos");
                Console.WriteLine("2 - Ações Multilíngues com Action<string>");
                Console.WriteLine("3 - Cálculo de Área Utilizando Func");
                Console.WriteLine("4 - Monitoramento de Temperatura com Evento Personalizado");
                Console.WriteLine("5 - Notificação de Conclusão de Download com Eventos");
                Console.WriteLine("6 - Sistema de Registro com Multicast Delegate");
                Console.WriteLine("7 - Garantia de Robustez em Invocação de Delegates");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite o número do exercício desejado: ");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine();
                    switch (opcao)
                    {
                        case 1:
                            Exercicio1.Executar();
                            break;
                        case 2:
                            Exercicio2.Executar();
                            break;
                        case 3:
                            Exercicio3.Executar();
                            break;
                        case 4:
                            Exercicio4.Executar();
                            break;
                        case 5:
                            Exercicio5.Executar();
                            break;
                        case 6:
                            Exercicio6.Executar();
                            break;
                        case 7:
                            Exercicio7.Executar();
                            break;
                        case 0:
                            Console.WriteLine("A encerrar a aplicação...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida! Escolha uma opção do menu.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Digite apenas números.");
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }

            } while (opcao != 0);
        }
    }
}