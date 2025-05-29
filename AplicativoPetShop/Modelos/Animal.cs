using System;
using AplicativoPetShop.Modelos;

namespace AplicativoPetShop;

public class Animal
{
    public string? Nome { get; set; }
    protected int Idade { get; set; }
    protected double Peso { get; set; }
    public Dono? Dono { get; set; }

    protected void ApresentarAnimal()
    {
        Console.WriteLine("====Ficha do Animal====");
        Console.WriteLine("---Dados do animal---");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Peso: {Peso}");

        Console.WriteLine("---Dados do dono---");
        if (Dono != null)
        {
            Dono.ApresentarDono();
        }
        else
            Console.WriteLine("Este animal não possui um dono registrado.");
    }
}



