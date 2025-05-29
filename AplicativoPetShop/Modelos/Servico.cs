using System;

namespace AplicativoPetShop.Modelos;

public class Servico
{
    public static void ConsultarComVeterinario(Animal animal)
    {
        Console.WriteLine($"Consulta agendada para {animal.Nome}.");
    }

    public static void Tosar(Animal animal)
    {
        if (animal is Cachorro)
        {
            Console.WriteLine($"Tosa agendada para {animal.Nome}.");
        }
        else
            Console.WriteLine($"Tosas são disponíveis apenas para cachorros. {animal.Nome} é um {animal.GetType().Name}");
    }

    public static void TomarBanho(Animal animal)
    {
        if (animal is Cachorro || animal is Gato)
        {
            Console.WriteLine($"Banho agendado para {animal.Nome}.");
        }
        else
            Console.WriteLine($"Banhos são disponíveis apenas para gatos e cachorros. {animal.Nome} é um {animal.GetType().Name}");
    }

    public static void Vacinar(Animal animal)
    {
        Console.WriteLine($"Vacinação agendada para {animal.Nome}");
    }

    public static void LimparGaiola(Animal animal)
    {
        if (animal is Passaro)
        {
            Console.WriteLine($"Limpeza de gaiola agendada para {animal.Nome}");
        }
        else
            Console.WriteLine($"Limpeza de gaiola é restringida aos pássaros. {animal.Nome} é um {animal.GetType().Name}");
    }

    public static void EscovarPelo(Animal animal)
    {
        if (animal is Cachorro || animal is Gato)
        {
            Console.WriteLine($"Escovação de pelo agendada para {animal.Nome}");
        }
        else
            Console.WriteLine($"Escovação de pelo é restringida aos gatos e cachorros. {animal.Nome} é um {animal.GetType().Name}");
    }
}
