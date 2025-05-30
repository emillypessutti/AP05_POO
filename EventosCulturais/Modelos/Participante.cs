using System;

namespace EventosCulturais.Modelos;

public class Participante
{
    public string Nome { get; set; }
    public List<Evento> EventosInscritos { get; }

    public Participante(string nome)
    {
        Nome = nome;
        EventosInscritos = new List<Evento>();
    }

    public void Inscrever(Evento evento)
    {
        EventosInscritos.Add(evento);
        evento.AdicionarParticipante(this);
    }
}
