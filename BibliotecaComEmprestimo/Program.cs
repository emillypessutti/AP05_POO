using BibliotecaComEmprestimo.Modelos;

Leitor leitor1 = new("Emilly");
Leitor leitor2 = new("Iva");

Livro livro1 = new("A Seleção", "Kiera Cass");
Livro livro2 = new Livro("O Hobbit", "J.R.R. Tolkien");

Emprestimo.RealizarEmprestimo(leitor1, livro1);
Emprestimo.RealizarEmprestimo(leitor2, livro1);
Emprestimo.RealizarEmprestimo(leitor2, livro2);

Emprestimo.MostrarEmprestimo(leitor1);
Emprestimo.MostrarEmprestimo(leitor2);