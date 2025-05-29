using System;

namespace BibliotecaComEmprestimo.Modelos;

public class Livro
{
    public string? Titulo { get; set; }
    public string? Autor { get; set; }
    public bool Disponivel { get; set; } = true;

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
        Disponivel = true;
    }

}
