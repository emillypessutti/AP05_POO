using System;

namespace CadastroEscolar.Modelos;

public class Professor : Pessoa
{
    public string? Disciplinas { get; set; }

    public Professor(string nome, string cpf, DateTime dataNascimento, string disciplinas)
    {
        Nome = nome;
        CPF = cpf;
        DataNascimento = dataNascimento;
        Disciplinas = disciplinas;
    }
}
