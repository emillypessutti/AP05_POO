using System;

namespace ControleDeTreinos.Modelos;

public class Exercicio
{
    public string Nome { get; set; }
    public int Series { get; set; }
    public int Repeticoes { get; set; }
    public double Carga { get; set; }

    public Exercicio(string nome, int series, int repeticoes, double carga)
    {
        Nome = nome;
        Series = series;
        Repeticoes = repeticoes;
        Carga = carga;
    }

    public double CalcularCargaTotal()
    {
        return Series * Repeticoes * Carga;
    }

    public void Exibir()
    {
        Console.WriteLine($"{Nome} - {Series}x{Repeticoes} @ {Carga}kg");
    }
}
