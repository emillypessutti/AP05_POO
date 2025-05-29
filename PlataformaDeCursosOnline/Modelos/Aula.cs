using System;

namespace PlataformaDeCursosOnline.Modelos;

public class Aula
{
    public string Titulo { get; set; }
    public int Duracao { get; set; } 
    public string Professor { get; set; }

    public Aula(string titulo, int duracao, string professor)
    {
        Titulo = titulo;
        Duracao = duracao;
        Professor = professor;
    }
    public override string ToString()
    {
        return $"  - Aula: {Titulo}, Duração: {Duracao} min, Professor: {Professor}";
    }
}
