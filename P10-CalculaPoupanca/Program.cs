using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula poupança (While)");

        double investimento = 1000;

        // Rendimento de 0.5% (0.005) ao mês
        double rendimento = 0.005;
        
        int i = 0;

        while (i != 12)
        {
            investimento += investimento * rendimento;
            Console.WriteLine($"Mês {i + 1}: {investimento:F2}");
            i++;    
        }
        
        Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
        Console.ReadLine();
    }
}