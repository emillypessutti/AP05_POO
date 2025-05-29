using System;

namespace BibliotecaComEmprestimo.Modelos;

public class Emprestimo
{
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucao { get; set; }

    public Livro? livro { get; set; }
    public Leitor? leitor { get; set; }
}
