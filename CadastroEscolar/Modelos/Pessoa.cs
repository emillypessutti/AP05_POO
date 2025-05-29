using System;

namespace CadastroEscolar.Modelos;

public class Pessoa
{
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    public DateTime DataNascimento { get; set; }    
    public static void MostrarPessoa(Pessoa pessoa)
    {
        Console.WriteLine($"Nome: {pessoa.Nome} | CPF: {pessoa.CPF} | Data de nascimento: {pessoa.DataNascimento.ToString("dd/MM/yyyy")}");
    }
}
