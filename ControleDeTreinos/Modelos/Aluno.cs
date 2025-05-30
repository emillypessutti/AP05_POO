using System;

namespace ControleDeTreinos.Modelos;

public class Aluno
{
    public string Nome { get; }
    public int Idade { get; }
    public string ObjetivoFisico { get; }
    public string MedidasCorporais { get; }

    private List<Treino> Treinos { get; }

    public Aluno(string nome, int idade, string objetivoFisico, string medidasCorporais)
    {
        Nome = nome;
        Idade = idade;
        ObjetivoFisico = objetivoFisico;
        MedidasCorporais = medidasCorporais;
        Treinos = new List<Treino>();
    }

    public void AdicionarTreino(Treino treino)
    {
        Treinos.Add(treino);
    }

    public void ExibirTreinos()
    {
        Console.WriteLine($"\nAluno: {Nome} ({Idade} anos)\nObjetivo: {ObjetivoFisico}\nMedidas: {MedidasCorporais}\n");

        foreach (var treino in Treinos)
        {
            treino.Exibir();
        }
    }
}
