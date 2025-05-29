using AplicativoPetShop;
using AplicativoPetShop.Modelos;

Dono dono1 = new("Emilly", "12356", "Casa 1");

Dono dono2 = new("Mariana", "12345", "Casa 2");


Cachorro cachorro = new("Yumi", 5, 7.5, "Vira-Lata", "Grande", "Dócil", dono1);

Gato gato = new("Marrie", 2, 3, "Clara", "Dócil", dono2);

Passaro passaro = new("Rio", 6, 1.2, "Arara-azul", 1, dono1);

Servico.ConsultarComVeterinario(cachorro);
Servico.Tosar(cachorro);
Servico.LimparGaiola(passaro);
Servico.EscovarPelo(gato);
Servico.TomarBanho(cachorro);
Servico.Vacinar(passaro);
