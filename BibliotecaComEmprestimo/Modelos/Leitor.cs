using System;

namespace BibliotecaComEmprestimo.Modelos;

public class Leitor
{
    public string? Nome { get; set; }

    public List<Emprestimo> Emprestimos = new();

    public Leitor(string nome)
    {
        Nome = nome;
    }
}
