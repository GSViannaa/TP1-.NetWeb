using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Logger
    {
        public static void LogToConsole(string mensagem)
        {
            Console.WriteLine(mensagem + " no console...");
        }

        public static void LogToFile(string mensagem)
        {
            Console.WriteLine(mensagem + " no arquivo...");
        }

        public static void LogToDatabase(string mensagem)
        {
            Console.WriteLine(mensagem + " no banco de dados...");
        }
    }
}
