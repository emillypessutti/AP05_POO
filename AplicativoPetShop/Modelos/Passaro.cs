using System;

namespace AplicativoPetShop.Modelos;

public class Passaro : Animal
{
    private string? _especie { get; set; }
    private double _envergadura { get; set; }

    public Passaro(string nome, int idade, double peso, string especie, double envergadura, Dono dono)
    {
        Nome = nome;
        Idade = idade;
        Peso = peso;
        _especie = especie;
        _envergadura = envergadura;
        Dono = dono;
    
        ApresentarAnimal();
        ApresentarPassaro();
    }

    protected void ApresentarPassaro()
    {
        Console.WriteLine("---Detalhes específicos do pássaro---");
        Console.WriteLine($"Espécie: {_especie}");
        Console.WriteLine($"Envergadura: {_envergadura}");
        Console.WriteLine("======================\n");
    }
}
