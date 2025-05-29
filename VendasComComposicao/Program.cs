using VendasComComposicao.Modelos;

Produto produto1 = new("Caneta", 2.50, "001");
Produto produto2 = new("Caderno", 15.90, "002");

var pedido = new Pedido();

pedido.AdicionarItem(new ItemPedido(produto1, 3)); // 3 canetas
pedido.AdicionarItem(new ItemPedido(produto2, 2)); // 2 cadernos

pedido.ExibirResumo();