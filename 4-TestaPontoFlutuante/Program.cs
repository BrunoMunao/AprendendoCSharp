using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");

        double salario = 1250.70;
        Console.WriteLine(salario);
        Console.WriteLine("Meu salario é " + salario);

        int divisao = 7 / 5;
        Console.WriteLine(divisao);

        double divisao2 = 7.0 / 5;
        Console.WriteLine(divisao2);

        Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
        Console.ReadLine();
    }
}