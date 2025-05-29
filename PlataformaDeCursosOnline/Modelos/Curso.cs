using System;

namespace PlataformaDeCursosOnline.Modelos;

public class Curso
{
    public string NomeCurso { get; set; }
    public List<Aula> Aulas { get; private set; }

    public Curso(string nomeCurso)
    {
        NomeCurso = nomeCurso;
        Aulas = new List<Aula>();
    }

    public void AdicionarAula(Aula aula)
    {
        Aulas.Add(aula);
    }

    public void ListarAulas()
    {
        Console.WriteLine($"Aulas do Curso '{NomeCurso}':");
        if (Aulas.Count == 0)
        {
            Console.WriteLine("  Nenhuma aula cadastrada neste curso.");
            return;
        }
        foreach (var aula in Aulas)
        {
            Console.WriteLine(aula);
        }
    }

    public override string ToString()
    {
        return NomeCurso;
    }
}
