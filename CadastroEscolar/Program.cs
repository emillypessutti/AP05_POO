using CadastroEscolar.Modelos;

Aluno aluno = new("Emilly", "789.456.123-21", new DateTime(2003, 9, 27), "a1234567", "CC2004");
Professor professor = new("Ana", "123.456.789-10", new DateTime(1991, 11, 9), "Cálculo I");
Funcionario funcionario = new("Antonio", "456.123.789-25", new DateTime(1965, 8, 25), "Secretaria Acadêmica");

List<Pessoa> pessoas = new()
{
    aluno,
    professor,
    funcionario
};

foreach (var pessoa in pessoas)
{
    Pessoa.MostrarPessoa(pessoa);
}