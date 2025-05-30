using System;

namespace EventosCulturais.Modelos;

public class Show : Evento
{
    public string Artista { get; }
    public string EstiloMusical { get; }
    public string ClassificacaoEtaria { get; }

    public Show(string titulo, DateTime data, string horario, string local, int capacidade,
                string artista, string estilo, string classificacao)
        : base(titulo, data, horario, local, capacidade)
    {
        Artista = artista;
        EstiloMusical = estilo;
        ClassificacaoEtaria = classificacao;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Show: {Titulo} - {Data:d} às {Horario}, Local: {Local}");
        Console.WriteLine($"Artista: {Artista}, Estilo: {EstiloMusical}, Classificação: {ClassificacaoEtaria}");
    }
}
