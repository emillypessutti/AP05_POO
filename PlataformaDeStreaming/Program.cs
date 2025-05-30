using PlataformaDeStreaming.Modelos;

var filme = new Filme("Barbie", 118, "Comédia", "Greta Gerwig", 2023, new List<string> { "Margot Robbie", "Ryan Gosling" });

var episodios = new List<Episodio>
        {
            new Episodio("Piloto", 50),
            new Episodio("A Volta", 45)
        };
var serie = new Serie("Dark", 95, "Mistério", 3, episodios);

var doc = new Documentario("Senna: O Brasileiro, O Herói, O Campeão", 106, "História", "Vida e carreira de Ayrton Senna", "Asif Kapadia");

List<Midia> catalogo = new List<Midia> { filme, serie, doc };

Console.WriteLine("Catálogo de Mídia:\n");
foreach (var midia in catalogo)
{
    midia.ExibirResumo();
}