using System;

namespace AplicativoPetShop.Modelos;

public class Dono
{
    public string? Nome { get; set; }
    private string? _celular { get; set; }
    private string? _endereco { get; set; }

    public List<Animal> Animais { get; set; } = new();

    public Dono(string nome, string celular, string endereco)
    {
        Nome = nome;
        _celular = celular;
        _endereco = endereco;
    }
    public void ApresentarDono()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Celular: {_celular}");
        Console.WriteLine($"Endereço: {_endereco}");
    }


}
