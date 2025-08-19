// Programa para ordenar um array de instâncias da classe Aluno por ID e notas
using System;

public class Aluno : IComparable<Aluno>
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Nota { get; set; }

    // Construtor
    public Aluno(int id, string nome, double nota)
    {
        Id = id;
        Nome = nome;
        Nota = nota;
    }

    // Implementação de IComparable para ordenação por ID
    public int CompareTo(Aluno other)
    {
        return this.Id.CompareTo(other.Id);
    }

    // ToString para exibição
    public override string ToString()
    {
        return $"ID: {Id}, Nome: {Nome}, Nota: {Nota:F2}";
    }
}

// Comparador para ordenação por nota
public class ComparadorPorNota : IComparer<Aluno>
{
    public int Compare(Aluno x, Aluno y)
    {
        return x.Nota.CompareTo(y.Nota);
    }
}

class AlunoSort
{
    static void Main(string[] args)
    {
        // Criação do array de alunos
        Aluno[] alunos = new Aluno[]
        {
            new Aluno(3, "Carlos", 8.5),
            new Aluno(1, "Ana", 9.0),
            new Aluno(4, "Beatriz", 7.5),
            new Aluno(2, "Daniel", 8.0)
        };

        // Ordenação por ID
        Console.WriteLine("Ordenado por ID:");
        Array.Sort(alunos);
        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }

        // Ordenação por nota
        Console.WriteLine("\nOrdenado por Nota:");
        Array.Sort(alunos, new ComparadorPorNota());
        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }
    }
}