using System;

public class Program
{
    public static void Main(string[] args)
    {
        Action boasVindasPt = () => Console.WriteLine("Olá, mundo!");
        Action boasVindasEn = () => Console.WriteLine("Hello, world!");
        Action boasVindasEs = () => Console.WriteLine("¡Hola, mundo!");

        try
        {
            Console.WriteLine("Escolha um idioma: 1 - português | 2 - inglês | 3 - espanhol");
            int idioma = int.Parse(Console.ReadLine());

            switch (idioma)
            {
                case 1:
                    boasVindasPt();
                    break;

                case 2:
                    boasVindasEn();
                    break;

                case 3:
                    boasVindasEs();
                    break;

                default:
                    Console.WriteLine("Idioma não suportado.");
                    break;
            }
        }
        catch
        {
            Console.WriteLine("Erro: Valor inválido. Por favor, insira um número válido.");
        }



    }
}