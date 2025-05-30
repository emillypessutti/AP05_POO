using System;

namespace PlataformaDeStreaming.Modelos;

public class Serie : Midia
{
    public int Temporadas { get; }
    public List<Episodio> Episodios { get; }

    public Serie(string titulo, int duracao, string genero, int temporadas, List<Episodio> episodios)
        : base(titulo, duracao, genero)
    {
        Temporadas = temporadas;
        Episodios = episodios;
    }

    public override void ExibirResumo()
    {
        Console.WriteLine($"Série: {Titulo} - {Genero}\nTemporadas: {Temporadas}, Episódios: {Episodios.Count}, Duração total: {Duracao} min\n");
    }
}
