using System;

namespace BibliotecaComEmprestimo.Modelos;

public class Emprestimo
{
    public DateTime DataEmprestimo { get; set; }
    public DateTime? DataDevolucao { get; set; }

    public Livro? LivroEmprestado { get; set; }
    public Leitor? Leitor { get; set; }

    public Emprestimo(Leitor leitor, Livro livro)
    {
        Leitor = leitor;
        LivroEmprestado = livro;
        DataEmprestimo = DateTime.Now;
        DataDevolucao = null;
    }

    public static void RealizarEmprestimo(Leitor leitor, Livro livro)
    {
        if (livro.Disponivel)
        {
            Emprestimo emprestimo1 = new(leitor, livro);
            leitor.Emprestimos.Add(emprestimo1);
            livro.Disponivel = false;

            Console.WriteLine($"{leitor.Nome} realizou emprésitmo do {livro.Titulo} em {emprestimo1.DataEmprestimo.ToString("dd/MM/yyyy")}.");
        }
        else
            Console.WriteLine($"O livro {livro.Titulo} não está disponível.");
    }

    public static void MostrarEmprestimo(Leitor leitor)
    {
        Console.WriteLine($"\n==== Lista de empréstimos realizados pelo leitor {leitor.Nome} ====\n");
        foreach (var emprestimo in leitor.Emprestimos)
        {
            Console.WriteLine($"Livro: {emprestimo.LivroEmprestado?.Titulo} | Autor(a): {emprestimo.LivroEmprestado?.Autor} | Data de empréstimo: {emprestimo.DataEmprestimo.ToString("dd/MM/yyyy")}\n");
        }
    }
}
