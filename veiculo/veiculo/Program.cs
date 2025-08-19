// Programa para definir classes Veículo e Motor, com controle de viagem e exceção
using System;

public class Motor
{
    public bool Ligado { get; private set; }

    // Método para ligar o motor
    public void Ligar()
    {
        Ligado = true;
        Console.WriteLine("Motor ligado.");
    }

    // Método para desligar o motor
    public void Desligar()
    {
        Ligado = false;
        Console.WriteLine("Motor desligado.");
    }
}

public class Veiculo
{
    private Motor motor;
    private double velocidade;
    private double distanciaPercorrida;
    private double destino;

    // Construtor
    public Veiculo(double destino)
    {
        motor = new Motor();
        this.destino = destino;
        distanciaPercorrida = 0;
    }

    // Método para iniciar viagem
    public void Viajar(double velocidade, double distancia)
    {
        if (!motor.Ligado)
        {
            motor.Ligar();
        }

        this.velocidade = velocidade;
        double novaDistancia = distanciaPercorrida + distancia;

        // Verifica se a distância excede o destino
        if (novaDistancia > destino)
        {
            throw new Exception($"Erro: Tentativa de viajar {novaDistancia:F2}km, mas o destino é {destino:F2}km.");
        }

        distanciaPercorrida = novaDistancia;
        Console.WriteLine($"Veículo viajou {distancia:F2}km a {velocidade:F2}km/h. Distância total: {distanciaPercorrida:F2}km.");

        // Desliga o motor se chegou ao destino
        if (distanciaPercorrida >= destino)
        {
            motor.Desligar();
        }
    }
}

class VeiculoApp
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite a distância do destino (km): ");
            double destino = double.Parse(Console.ReadLine());
            Console.Write("Digite a velocidade (km/h): ");
            double velocidade = double.Parse(Console.ReadLine());
            Console.Write("Digite a distância a percorrer (km): ");
            double distancia = double.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(destino);
            veiculo.Viajar(velocidade, distancia);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}