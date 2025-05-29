using System;

namespace VendasComComposicao.Modelos;

public class Pedido
{
    private List<ItemPedido> itens = new();

    public void AdicionarItem(ItemPedido item)
    {
        itens.Add(item);
    }

    public double CalcularTotal()
    {
        double total = 0;
        foreach (var item in itens)
        {
            total += item.Subtotal();
        }
        return total;
    }
    
     public void ExibirResumo()
    {
        Console.WriteLine("Resumo do Pedido:");
        foreach (var item in itens)
        {
            Console.WriteLine($"{item.Produto.Nome} - {item.Quantidade} x R$ {item.Produto.Preco:F2} = R$ {item.Subtotal():F2}");
        }
        Console.WriteLine($"Total: R$ {CalcularTotal():F2}");
    }
}
