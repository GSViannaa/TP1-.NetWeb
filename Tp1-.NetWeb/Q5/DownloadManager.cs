using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    public class DownloadManager
    {

        public delegate void DownloadCompletedHandler(String mensagem);

        public event DownloadCompletedHandler DownloadCompleted;

        public void IniciarDownload()
        {
            Console.WriteLine("Iniciando download...");
          
            System.Threading.Thread.Sleep(3000);

            OnDownloadCompleted("Download finalizado com sucesso");
        }



        protected virtual void OnDownloadCompleted(string mensagem)
        {
            DownloadCompleted?.Invoke(mensagem);
        }
    }

     
}
