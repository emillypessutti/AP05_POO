using System;

namespace AplicativoPetShop.Modelos;

public class Gato : Animal
{
    private string? _pelagem { get; set; }
    private string? _comportamento { get; set; }

    public Gato(string nome, int idade, double peso, string pelagem, string comportamento, Dono dono)
    {
        Nome = nome;
        Idade = idade;
        Peso = peso;
        _pelagem = pelagem;
        _comportamento = comportamento;
        Dono = dono;
    
        ApresentarAnimal();
        ApresentarGato();
    }

    protected void ApresentarGato()
    {
        Console.WriteLine("---Detalhes específicos do gato---");
        Console.WriteLine($"Pelagem: {_pelagem}");
        Console.WriteLine($"Comportamento: {_comportamento}");
        Console.WriteLine("======================\n");
    }
}
