using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Desafio - Fatorial");
        int somaFatorial = 1;
        int fatorial = 6;


        for (int i = 1; i <= fatorial; i++) 
        {
            somaFatorial *= i;
        }

        Console.WriteLine($"Fatorial de {fatorial}: {somaFatorial}");

        Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
        Console.ReadLine();
    }
}