using System;
using System.Collections.Generic;

namespace TP_Desenvolvimento_WEB
{
    public class Exercicio2
    {
        public static void Executar()
        {
            Console.WriteLine("Escolha o idioma (1 - Português, 2 - Inglês, 3 - Espanhol): ");
            string escolha = Console.ReadLine();

            
            Dictionary<string, Action<string>> mensagensIdiomas = new Dictionary<string, Action<string>>()
            {
                { "1", nome => Console.WriteLine($"\nBem-vindo(a), {nome}! É um prazer tê-lo(a) conosco.") },
                { "2", nome => Console.WriteLine($"\nWelcome, {nome}! It's a pleasure to have you with us.") },
                { "3", nome => Console.WriteLine($"\n¡Bienvenido(a), {nome}! Es un placer tenerle con nosotros.") }
            };

            if (mensagensIdiomas.ContainsKey(escolha))
            {
                Console.Write("Informe o seu nome: ");
                string nomeUsuario = Console.ReadLine();

                mensagensIdiomas[escolha](nomeUsuario);
            }
            else
            {
                Console.WriteLine("Opcaoo invalida.");
            }
        }
    }
}