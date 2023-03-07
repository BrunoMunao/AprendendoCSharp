using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char) 65;
        Console.WriteLine(letra);

        letra = (char) (65 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = @"Cursos disponíveis: 
- Go 
- C# 
- Python 
- Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
        Console.ReadLine();
    }
}