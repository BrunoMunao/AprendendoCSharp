using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Sim, João pode entrar no festival!");
        }
        else
        {
            Console.WriteLine("Não, João não pode entrar no festival!");
        }

        Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
        Console.ReadLine();
    }
}