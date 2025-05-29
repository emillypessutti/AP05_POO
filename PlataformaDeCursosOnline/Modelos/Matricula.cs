using System;

namespace PlataformaDeCursosOnline.Modelos;

public class Matricula
{
    public Estudante Estudante { get; set; }
    public Curso CursoMatriculado { get; set; }
    public DateTime DataInscricao { get; set; }

    public Matricula(Estudante estudante, Curso cursoMatriculado, DateTime dataInscricao)
    {
        Estudante = estudante;
        CursoMatriculado = cursoMatriculado;
        DataInscricao = dataInscricao;
    }

    public override string ToString()
    {
        return $"Matrícula:\n  {Estudante.Nome}\n  Curso: {CursoMatriculado.NomeCurso}\n  Data de Inscrição: {DataInscricao:dd/MM/yyyy}\n";
    }
}
