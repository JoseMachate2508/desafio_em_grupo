// Programa para definir uma classe Shape e calcular volumes de cubo, cone e esfera
using System;

public class Shape
{
    // Membros de dados
    public double Comprimento { get; set; }
    public double Largura { get; set; }
    public double Altura { get; set; }
    public double Raio { get; set; }

    // Construtor para cubo
    public Shape(double comprimento, bool isCubo)
    {
        if (!isCubo)
            throw new ArgumentException("Este construtor é apenas para cubos.");
        Comprimento = comprimento;
        Largura = comprimento;
        Altura = comprimento;
    }

    // Construtor para cone
    public Shape(double raio, double altura)
    {
        Raio = raio;
        Altura = altura;
    }

    // Construtor para esfera
    public Shape(double raio, string tipo)
    {
        if (tipo != "esfera")
            throw new ArgumentException("Este construtor é apenas para esferas.");
        Raio = raio;
    }

    // Método para calcular volume do cubo
    public double CalcularVolumeCubo()
    {
        return Comprimento * Largura * Altura;
    }

    // Método para calcular volume do cone
    public double CalcularVolumeCone()
    {
        return (4.0 / 3.0) * Math.PI * Raio * Raio * Altura;
    }

    // Método para calcular volume da esfera
    public double CalcularVolumeEsfera()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(Raio, 3);
    }
}

class ShapeApp
{
    static void Main(string[] args)
    {
        // Criação dos objetos
        Shape cubo = new Shape(5.0, true); // Cubo com lado 5
        Shape cone = new Shape(3.0, 7.0); // Cone com raio 3 e altura 7
        Shape esfera = new Shape(4.0, "esfera"); // Esfera com raio 4

        // Cálculo e exibição dos volumes
        Console.WriteLine($"Volume do cubo: {cubo.CalcularVolumeCubo():F2}");
        Console.WriteLine($"Volume do cone: {cone.CalcularVolumeCone():F2}");
        Console.WriteLine($"Volume da esfera: {esfera.CalcularVolumeEsfera():F2}");
    }
}