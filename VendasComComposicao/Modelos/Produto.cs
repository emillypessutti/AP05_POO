using System;

namespace VendasComComposicao.Modelos;

public class Produto
{
    public string? Nome { get; set; }
    public double Preco { get; set; }
    public string? Codigo { get; set; }

    public Produto(string nome, double preco, string codigo)
    {
        Nome = nome;
        Preco = preco;
        Codigo = codigo;
    }
}
