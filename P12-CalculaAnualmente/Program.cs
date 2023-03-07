using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Calcula poupança (For Aninhado)");

        double investimento = 1000;

        // Rendimento de 0.5% (0.005) ao mês
        double rendimento = 0.005;
        for (int ano = 0; ano != 5; ano++)
        {
            for (int mes = 0; mes != 12; mes++)
            {
                investimento += investimento * rendimento;
                Console.WriteLine($"Ano: {ano + 1} / Mês {mes + 1}: {investimento:F2}");
            }
            rendimento += 0.001;
        }

        Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
        Console.ReadLine();
    }
}