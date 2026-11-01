using System;

namespace Tp_1_C__ASP_NET
{
    public class Ex11
    {
        public static void Executar()
        {
            Console.Clear();

            Func<string, string, string>
    cadeiaDeOperacoes = (nome, sobrenome) =>
    {
    string res = $"{nome} {sobrenome}";
    Console.WriteLine($"[1] Concatenação: {res}");
    return res;
    };

    cadeiaDeOperacoes += (nome, sobrenome) =>
    {
    string res = $"{nome} {sobrenome}".ToUpper();
    Console.WriteLine($"[2] Maiúsculas: {res}");
    return res;
    };

    cadeiaDeOperacoes += (nome, sobrenome) =>
    {
    string res = $"{nome}{sobrenome}".Replace(" ", "");
    Console.WriteLine($"[3] Sem Espaços: {res}");
    return res;
    };

    Console.WriteLine("\nInvocando o delegate com os argumentos 'Gabriel' e 'Casarotto':");
    string resultadoFinal = cadeiaDeOperacoes("Gabriel", "Casarotto");

    Console.WriteLine($"\n-> Valor final retornado pelo delegate: '{resultadoFinal}'");
    }
 }
}
