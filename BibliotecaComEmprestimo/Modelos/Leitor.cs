using System;

namespace BibliotecaComEmprestimo.Modelos;

public class Leitor
{
    public string? Nome { get; set; }

    public List<Emprestimo> Emprestimos = new();

    public void AdicionarEmprestimo(Emprestimo emprestimo)
    {
        Emprestimos.Add(emprestimo);
    }   
}
