using System;


public class Program
{
    public delegate double Callback(double precoOriginal, double porcentagemDesconto);
    public static void Main(string[] args)
    {
        Callback handler = CalculateDiscount;

        double porcentagemDesconto = 0.10;

        try
        {
            Console.WriteLine("Insira o preço original do produto:");
            double precoOriginal = double.Parse(Console.ReadLine());

            double preçoFinal = handler(precoOriginal, porcentagemDesconto);

            Console.WriteLine($"Preço com desconto: {preçoFinal}");

        }
        catch (Exception)
        {
            Console.WriteLine("Erro: Valor inválido. Por favor, insira um preço válido.");
        }


    }
    public static double CalculateDiscount(double precoOriginal, double porcentagemDesconto)
    {
        return precoOriginal - (precoOriginal * porcentagemDesconto);
    }


}