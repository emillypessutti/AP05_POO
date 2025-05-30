using SistemaDeRecrutamento.Modelos;

var vaga1 = new Vaga("Desenvolvedor", "Frimesa", "Desenvolvimento de sistemas Oracle.");
var vaga2 = new Vaga("Analista de Dados", "Facebook", "Análise e modelagem de dados.");

var candidato1 = new Candidato("Maria Silva", "maria@gmail.com", "Formada em Ciência da Computação.");
var candidato2 = new Candidato("Antonio Carlos", "antonio@gmail.com", "Especialista em banco de dados.");

var candidatura1 = new Candidatura(candidato1, vaga1);
var candidatura2 = new Candidatura(candidato1, vaga2, "Em análise");
var candidatura3 = new Candidatura(candidato2, vaga1, "Aprovada");

var candidaturas = new List<Candidatura> { candidatura1, candidatura2, candidatura3 };

Console.WriteLine("====Lista de candidaturas:====\n");
foreach (var c in candidaturas)
{
    c.Exibir();
}