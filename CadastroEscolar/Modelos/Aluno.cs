using System;

namespace CadastroEscolar.Modelos;

public class Aluno : Pessoa
{
    public string? Matricula { get; set; }
    public string? Turma { get; set; }

    public Aluno(string nome, string cpf, DateTime dataNascimento, string matricula, string turma)
    {
        Nome = nome;
        CPF = cpf;
        DataNascimento = dataNascimento;
        Matricula = matricula;
        Turma = turma;
    }
}
