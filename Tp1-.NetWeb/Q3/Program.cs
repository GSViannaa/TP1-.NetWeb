using System;

public class Program
{

    public static void Main(string[] args)
    {
        Func<double, double, double> calcularArea = (baseTriangulo, alturaTriangulo) => (baseTriangulo * alturaTriangulo) / 2;

        try
        {
            Console.WriteLine("Insira a base do triângulo:");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a altura do triângulo:");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            double area = calcularArea(baseTriangulo, alturaTriangulo);

            Console.WriteLine($"Área do triângulo: {area}");
        }
        catch
        {
            Console.WriteLine("Erro: Valor inválido. Por favor, insira um número válido.");
        }
    }
}