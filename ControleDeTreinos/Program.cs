using ControleDeTreinos.Modelos;

Aluno aluno = new Aluno("Emilly Pessutti", 21, "Resistência", "Altura: 1.73m, Peso: 56kg");

Treino treinoSuperior = new Treino("Hipertrofia", "Superior");
treinoSuperior.AdicionarExercicio(new Exercicio("Supino Reto", 4, 10, 60));
treinoSuperior.AdicionarExercicio(new Exercicio("Desenvolvimento", 3, 12, 40));

Treino treinoInferior = new Treino("Resistência", "Inferior");
treinoInferior.AdicionarExercicio(new Exercicio("Agachamento", 4, 15, 50));

aluno.AdicionarTreino(treinoSuperior);
aluno.AdicionarTreino(treinoInferior);

aluno.ExibirTreinos();