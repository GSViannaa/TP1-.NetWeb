using System;

public class Program
{
    public delegate string StringDelegate(string str);
    public static void Main(string[] args)
    {
        Func<string, string, string> concatenar = (nome, sobrenome) => nome + " " + sobrenome;
        Func<string, string> paraMaiuscula = texto => texto.ToUpper();
        Func<string, string> removerEspaçosBrancos = texto => texto.Replace(" ", "");

        try
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome:");
            string sobrenome = Console.ReadLine();

            string nomeCompleto = concatenar(nome, sobrenome);
            string emMaisuculas = paraMaiuscula(nomeCompleto);
            string semEspacos = removerEspaçosBrancos(emMaisuculas);

            Console.WriteLine($"Resultado: {semEspacos}");
        }
        catch
        {
            Console.WriteLine("Ocorreu um erro ao processar os dados.");
        }


    }
}