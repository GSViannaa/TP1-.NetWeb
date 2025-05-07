using System;
using Q5;

public class Program
{
    public static void Main(String[] args)
    {
        DownloadManager downloadManager = new DownloadManager();

        downloadManager.DownloadCompleted += MostarMensagem;

        downloadManager.IniciarDownload();

    }

        static void MostarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }
}