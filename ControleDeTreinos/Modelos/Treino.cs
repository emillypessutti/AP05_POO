using System;

namespace ControleDeTreinos.Modelos;

public class Treino
{
    public DateTime DataCriacao { get; }
    public string Objetivo { get; }
    public string Tipo { get; }
    private List<Exercicio> Exercicios { get; }

    public Treino(string objetivo, string tipo)
    {
        DataCriacao = DateTime.Now;
        Objetivo = objetivo;
        Tipo = tipo;
        Exercicios = new List<Exercicio>();
    }

    public void AdicionarExercicio(Exercicio exercicio)
    {
        Exercicios.Add(exercicio);
    }

    public double CalcularCargaTotal()
    {
        double total = 0;
        foreach (var ex in Exercicios)
        {
            total += ex.CalcularCargaTotal();
        }
        return total;
    }

    public void Exibir()
    {
        Console.WriteLine($"Treino {Tipo} ({Objetivo}) - {DataCriacao:d}");
        foreach (var ex in Exercicios)
            ex.Exibir();

        Console.WriteLine($"Carga total: {CalcularCargaTotal()} kg\n");
    }
}
