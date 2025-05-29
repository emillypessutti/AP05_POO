using System;

namespace VeiculosEManutencoes.Modelos;

public class Veiculo
{
    public string? Modelo { get; set; }
    public string? Placa { get; set; }
    public string? Tipo { get; set; }

    private List<Manutencao> manutencoes = new List<Manutencao>();

    public Veiculo(string modelo, string placa, string tipo)
    {
        Modelo = modelo;
        Placa = placa;
        Tipo = tipo;
    }

    public bool AdicionarManutencao(Manutencao manutencao)
    {
        if (manutencoes.Any(m => m.DataServico.Date == manutencao.DataServico.Date))
        {
            Console.WriteLine($"Erro: Já existe uma manutenção registrada para {Placa} na data {manutencao.DataServico:dd/MM/yyyy}.");
            return false;
        }

        manutencoes.Add(manutencao);
        Console.WriteLine($"Manutenção adicionada para o veículo {Placa} na data {manutencao.DataServico:dd/MM/yyyy}.");
        return true;
    }

    public void ExibirHistorico()
    {
        Console.WriteLine($"\nHistórico de manutenções - Veículo {Modelo} ({Placa})");
        foreach (var m in manutencoes.OrderBy(m => m.DataServico))
        {
            Console.WriteLine($"{m.DataServico:dd/MM/yyyy} - {m.Tipo} - {m.Descricao}");
        }
    }
}
