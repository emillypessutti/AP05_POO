using System;

namespace PlataformaDeStreaming.Modelos;

public class Episodio
{
    public string Titulo { get; }
    public int Duracao { get; }

    public Episodio(string titulo, int duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
    }
}
