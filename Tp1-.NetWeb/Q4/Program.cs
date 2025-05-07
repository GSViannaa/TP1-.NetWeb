using System;
using Q4;

public class Program
{
    public static void Main(String[] args)
    {
        TemperatureSensor sensor = new TemperatureSensor();
        MostrarAlerta alerta = new MostrarAlerta();

        sensor.alertTemperatureExceeded += alerta.MostrarMensagem;

        try
        {
            Console.WriteLine("Insira a temperatuara atual:");
            double temperatura = double.Parse(Console.ReadLine());

            Console.WriteLine("Checando temperatura...");

            sensor.CheckTemperature(temperatura);

        }
        catch (Exception)
        {
            Console.WriteLine("Erro: Valor inválido. Por favor, insira uma temperatura válida.");
        }




    }
}