using System;

namespace PlataformaDeStreaming.Modelos;

public abstract class Midia
{
    public string Titulo { get; }
    public int Duracao { get; }
    public string Genero { get; }

    public Midia(string titulo, int duracao, string genero)
    {
        Titulo = titulo;
        Duracao = duracao;
        Genero = genero;
    }

    public abstract void ExibirResumo();
}
