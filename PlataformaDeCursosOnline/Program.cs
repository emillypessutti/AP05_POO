using PlataformaDeCursosOnline.Modelos;

Estudante estudante1 = new( "Emilly");
Estudante estudante2 = new("Mariana");

Aula aula1 = new Aula("Programação Orientada a Objetos", 60, "Prof. Everton");
Aula aula2 = new Aula("Cálculo I", 90, "Prof. Tatiane");

Curso curso1 = new Curso("Desenvolvimento em C#");
curso1.AdicionarAula(aula1);

Curso curso2 = new Curso("Aprendendo Matemática");
curso2.AdicionarAula(aula2);

Matricula matricula1 = new Matricula(estudante1, curso1, new DateTime(2025, 01, 15));

Matricula matricula2 = new Matricula(estudante2, curso1, new DateTime(2025, 02, 01));

Matricula matricula3 = new Matricula(estudante1, curso2, new DateTime(2025, 02, 20));


