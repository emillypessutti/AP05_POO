using System;

namespace PlataformaDeStreaming.Modelos;

public class Documentario : Midia
{
    public string Tema { get; }
    public string Narrador { get; }

    public Documentario(string titulo, int duracao, string genero, string tema, string narrador)
        : base(titulo, duracao, genero)
    {
        Tema = tema;
        Narrador = narrador;
    }

    public override void ExibirResumo()
    {
        Console.WriteLine($"Documentário: {Titulo} - {Genero}\nTema: {Tema}\nNarrador: {Narrador}, Duração: {Duracao} min\n");
    }
}
