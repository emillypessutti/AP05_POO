using System;

namespace EventosCulturais.Modelos;

public class Palestra : Evento
{
    public string Palestrante { get; }
    public string Topico { get; }
    public int Duracao { get; }

    public Palestra(string titulo, DateTime data, string horario, string local, int capacidade,
                    string palestrante, string topico, int duracao)
        : base(titulo, data, horario, local, capacidade)
    {
        Palestrante = palestrante;
        Topico = topico;
        Duracao = duracao;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Palestra: {Titulo} - {Data:d} às {Horario}, Local: {Local}");
        Console.WriteLine($"Palestrante: {Palestrante}, Tópico: {Topico}, Duração: {Duracao} min");
    }
}
