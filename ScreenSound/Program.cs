Banda nirvana = new Banda("Nirvana");

Album albumDoNirvana = new Album("Top 5 musicas mais ouvidas do Nirvana");

Musica musica1 = new Musica(nirvana, "Smells Like Teen Spirit")
{
    Duracao = 301,
    Disponivel = true
};

Musica musica2 = new Musica(nirvana, "Come As You Are")
{
    Duracao = 219,
    Disponivel = false
};

albumDoNirvana.AdicionarMusica(musica1);
albumDoNirvana.AdicionarMusica(musica2);
nirvana.AdicionarAlbum(albumDoNirvana);

musica1.exibirInformacoes();
musica2.exibirInformacoes();
albumDoNirvana.ExibirMusicasDoAlbum();
nirvana.ExibirDiscografia();

Console.WriteLine("\n=== PODCASTS ===\n");

Podcast meuPodcast = new Podcast("Tech Talk", "João Silva");

Episodio ep1 = new Episodio(1, "Introdução a C#", 45);
ep1.AdicionarConvidado("Maria Developer");
ep1.AdicionarConvidado("Pedro Coder");

Episodio ep2 = new Episodio(2, "Orientação a Objetos", 60);
ep2.AdicionarConvidado("Ana Arquiteta");

Episodio ep3 = new Episodio(3, "Async e Await", 55);
ep3.AdicionarConvidado("Carlos Backend");

meuPodcast.AdicionarEpisodio(ep1);
meuPodcast.AdicionarEpisodio(ep2);
meuPodcast.AdicionarEpisodio(ep3);

meuPodcast.ExibirDetalhes();
