using System;
using System.Runtime.CompilerServices;

namespace AplicativoPetShop.Modelos;

public class Cachorro : Animal
{
    private string? _raça { get; set; }

    private string? _porte { get; set; }

    private string? _temperamento { get; set; }

    public Cachorro(string nome, int idade, double peso, string raca, string porte, string temperamento, Dono dono)
    {
        Nome = nome;
        Idade = idade;
        Peso = peso;
        _raça = raca;
        _porte = porte;
        _temperamento = temperamento;
        Dono = dono;

        ApresentarAnimal();
        ApresentarCachorro();
    }

    protected void ApresentarCachorro()
    {
        Console.WriteLine("---Detalhes específicos do cachorro---");
        Console.WriteLine($"Raça: {_raça}");
        Console.WriteLine($"Porte: {_porte}");
        Console.WriteLine($"Temperamento: {_temperamento}");

        Console.WriteLine("======================\n");
    }
}
