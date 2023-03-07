using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e outros tipos ");

        double salario = 3000.13;
        Console.WriteLine("Salário: " + salario);

        int salarioInteiro = (int) salario; 
        Console.WriteLine("Salario inteiro: " + salarioInteiro);

        // O longo é um inteiro de 64 bits :)
        long x = 2000000000;
        Console.WriteLine("Long X: " + x);

        short y = 15000;
        Console.WriteLine("Short Y: " + y);

        float altura = 1.62f;
        Console.WriteLine("Altura em float: " + altura);    
     
        Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
        Console.ReadLine();
    }
}