using System;
using System.Threading;

namespace TP_Desenvolvimento_WEB
{
    public class DownloadEventArgs : EventArgs
    {
        public string FileName { get; }

        public DownloadEventArgs(string fileName)
        {
            FileName = fileName;
        }
    }

    public class DownloadManager
    {
        public event EventHandler<DownloadEventArgs> DownloadCompleted;

        public void StartDownload(string fileName)
        {
            Console.WriteLine($"\nFazendo download do arquivo: {fileName}...");

            Thread.Sleep(3000);

            Console.WriteLine($"[Download] Arquivo '{fileName}' baixado com sucesso!");

            OnDownloadCompleted(new DownloadEventArgs(fileName));
        }

        protected virtual void OnDownloadCompleted(DownloadEventArgs e)
        {
            DownloadCompleted?.Invoke(this, e);
        }
    }

    public class Exercicio5
    {
        public static void Executar()
        {

            DownloadManager manager = new DownloadManager();

            manager.DownloadCompleted += NotificarConclusaoDownload;

            Console.Write("Informe o nome do arquivo para download: ");
            string nomeArquivo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nomeArquivo))
            {
                nomeArquivo = "relatorio_vendas.pdf";
            }

            manager.StartDownload(nomeArquivo);

            manager.DownloadCompleted -= NotificarConclusaoDownload;
        }

        private static void NotificarConclusaoDownload(object sender, DownloadEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[NOTIFICAÇÃO DO SISTEMA] O arquivo '{e.FileName}' foi processado e está pronto para uso!");
            Console.ResetColor();
        }
    }
}