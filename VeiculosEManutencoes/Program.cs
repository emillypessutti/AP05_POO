using VeiculosEManutencoes.Modelos;

var veiculo = new Veiculo("Uno Mille", "ABC-1234", "Passeio");

var manutencao1 = new Manutencao(new DateTime(2025, 5, 10), "Troca de óleo", "Preventiva");
var manutencao2 = new Manutencao(new DateTime(2025, 5, 10), "Alinhamento", "Corretiva"); 

veiculo.AdicionarManutencao(manutencao1);
veiculo.AdicionarManutencao(manutencao2);

veiculo.ExibirHistorico();