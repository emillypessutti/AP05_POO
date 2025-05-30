using System;

namespace EventosCulturais.Modelos;

public abstract class Evento
{   
    public string Titulo { get; }
    public DateTime Data { get; }
    public string Horario { get; }
    public string Local { get; }
    public int Capacidade { get; }

    private List<Participante> Participantes { get; }

    public Evento(string titulo, DateTime data, string horario, string local, int capacidade)
    {
        Titulo = titulo;
        Data = data;
        Horario = horario;
        Local = local;
        Capacidade = capacidade;
        Participantes = new List<Participante>();
    }

    public void AdicionarParticipante(Participante p)
    {
        if (!Participantes.Contains(p))
            Participantes.Add(p);
    }

    public abstract void ExibirInformacoes();
}
