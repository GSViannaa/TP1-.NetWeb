using System;
using Q7;


public class Program
{
    public static void Main(string[] args)
    {
        Action<string> action = Logger.LogToConsole;
        action += Logger.LogToFile;
        action += Logger.LogToDatabase;

        action?.Invoke("Regisatrando");

    }

}