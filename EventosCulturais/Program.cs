using EventosCulturais.Modelos;

Participante maria = new Participante("Maria Oliveira");

Evento palestra = new Palestra("Tecnologia e Futuro", DateTime.Parse("2025-06-10"), "18:00", "Auditório A", 100,
                               "Dr. Pedro Lima", "IA e Sociedade", 90);

Evento oficina = new Oficina("Oficina de Cerâmica", DateTime.Parse("2025-06-11"), "14:00", "Sala 2", 20,
                             "Barro, torno", 15);

Evento show = new Show("Rock Cultural", DateTime.Parse("2025-06-12"), "20:00", "Palco Principal", 300,
                       "Banda Alpha", "Rock Alternativo", "Livre");

maria.Inscrever(palestra);
maria.Inscrever(oficina);

palestra.ExibirInformacoes();
oficina.ExibirInformacoes();
show.ExibirInformacoes();