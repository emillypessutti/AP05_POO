using System;

namespace SistemaDeRecrutamento.Modelos;

public class Vaga
{
    public string Titulo { get; }
    public string Empresa { get; }
    public string Descricao { get; }

    public Vaga(string titulo, string empresa, string descricao)
    {
        Titulo = titulo;
        Empresa = empresa;
        Descricao = descricao;
    }
}
