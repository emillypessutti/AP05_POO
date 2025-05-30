using System;

namespace EventosCulturais.Modelos;

public class Oficina : Evento
{
    public string MaterialNecessario { get; }
    public int MaxParticipantes { get; }

    public Oficina(string titulo, DateTime data, string horario, string local, int capacidade,
                   string materialNecessario, int maxParticipantes)
        : base(titulo, data, horario, local, capacidade)
    {
        MaterialNecessario = materialNecessario;
        MaxParticipantes = maxParticipantes;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Oficina: {Titulo} - {Data:d} às {Horario}, Local: {Local}");
        Console.WriteLine($"Material: {MaterialNecessario}, Máx participantes: {MaxParticipantes}");
    }
}
