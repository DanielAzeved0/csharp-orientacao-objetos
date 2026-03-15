class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida =>
        $"A música {Nome} pertence ao banda ou artisa {Artista}";

    public void exibirInformacoes()
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Disponível: {(Disponivel ? "Disponivel no seu plano" : "Não disponivel no seu plano")}");
    }
}
