// Programa para somar 5 inteiros lidos do teclado e retornar o resultado com um sinalizador de sucesso
using System;

class Program
{
    // Método AddInts para somar 5 inteiros
    // Usa out para retornar o resultado e um sinalizador de sucesso
    public static bool AddInts(out int sum)
    {
        sum = 0;
        try
        {
            Console.WriteLine("Digite 5 números inteiros:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Número {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Erro: Entrada inválida. Deve ser um número inteiro.");
                    return false;
                }
                sum += number;
            }
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar: {ex.Message}");
            return false;
        }
    }

    static void Main(string[] args)
    {
        // Chama o método AddInts e verifica o resultado
        if (AddInts(out int result))
        {
            Console.WriteLine($"Soma dos números: {result}");
        }
        else
        {
            Console.WriteLine("Falha ao realizar a soma.");
        }
    }
}