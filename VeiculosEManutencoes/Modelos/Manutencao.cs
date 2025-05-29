using System;

namespace VeiculosEManutencoes.Modelos;

public class Manutencao
{
    public DateTime DataServico { get; set; }
    public string? Descricao { get; set; }
    public string? Tipo { get; set; }

    public Manutencao(DateTime dataServico, string descricao, string tipo)
    {
        DataServico = dataServico;
        Descricao = descricao;
        Tipo = tipo;
    }
}
