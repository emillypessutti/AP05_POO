using System;

namespace SistemaDeRecrutamento.Modelos;

public class Candidatura
{
    public Candidato Candidato { get; }
    public Vaga Vaga { get; }
    public DateTime DataEnvio { get; }
    public string Status { get; set; }

    public Candidatura(Candidato candidato, Vaga vaga, string status = "Enviada")
    {
        Candidato = candidato;
        Vaga = vaga;
        DataEnvio = DateTime.Now;
        Status = status;
    }

    public void Exibir()
    {
        Console.WriteLine($"Candidato: {Candidato.Nome} - Vaga: {Vaga.Titulo} na {Vaga.Empresa} - Status: {Status} - Data: {DataEnvio:dd/MM/yyyy}");
    }
}
