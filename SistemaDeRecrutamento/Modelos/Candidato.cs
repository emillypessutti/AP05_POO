using System;

namespace SistemaDeRecrutamento.Modelos;

public class Candidato
{
    public string Nome { get; }
    public string Email { get; }
    public string Curriculo { get; }

    public Candidato(string nome, string email, string curriculo)
    {
        Nome = nome;
        Email = email;
        Curriculo = curriculo;
    }
}
