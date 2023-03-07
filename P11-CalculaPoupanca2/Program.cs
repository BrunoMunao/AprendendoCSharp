using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula poupança (For)");

        double investimento = 1000;

        // Rendimento de 0.5% (0.005) ao mês
        double rendimento = 0.005;

        for (int mes = 0; mes != 12; mes++)
        {
            investimento += investimento * rendimento;
            Console.WriteLine($"Mês {mes + 1}: {investimento:F2}");
        }

        Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
        Console.ReadLine();
    }
}