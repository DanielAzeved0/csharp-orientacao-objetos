class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome} - Host: {Host}");
        Console.WriteLine("\nEpisódios:");

        var episodiosOrdenados = episodios.OrderBy(e => e.Numero);

        foreach (var episodio in episodiosOrdenados)
        {
            Console.WriteLine($"- {episodio.Resumo}");
        }

        Console.WriteLine($"\nTotal de episódios: {TotalEpisodios}");
    }
}
