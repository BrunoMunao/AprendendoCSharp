using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Escopo");

        int idadeJoao = 16;
        int qtdDePessoas = 2;

        bool acompanhado = qtdDePessoas > 1;

        string textoAdicional;

        if (acompanhado)
        {
            textoAdicional = "João está acompanhado";
            // string textoAdicional = "João está acompanhado";
        }
        else
            textoAdicional = "João não está acompanhado";

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
            Console.WriteLine("Não pode entrar!");


        Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
        Console.ReadLine();
    }
}