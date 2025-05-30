
using System;

namespace PlataformaDeStreaming.Modelos;

public class Filme : Midia
{
    public string Diretor { get; }
    public int Ano { get; }
    public List<string> Elenco { get; }

    public Filme(string titulo, int duracao, string genero, string diretor, int ano, List<string> elenco)
        : base(titulo, duracao, genero)
    {
        Diretor = diretor;
        Ano = ano;
        Elenco = elenco;
    }

    public override void ExibirResumo()
    {
        Console.WriteLine($"Filme: {Titulo} ({Ano}) - {Genero}\nDiretor: {Diretor}\nDuração: {Duracao} min\nElenco: {string.Join(", ", Elenco)}\n");
    }
}
