using System;

namespace CadastroEscolar.Modelos;

public class Funcionario : Pessoa
{
    public string? Setor { get; set; }

    public Funcionario(string nome, string cpf, DateTime dataNascimento, string setor)
    {
        Nome = nome;
        CPF = cpf;
        DataNascimento = dataNascimento;
        Setor = setor;
    }
}
