class Episodio
{
    private List<string> convidados = new List<string>();

    public Episodio(int numero, string titulo, int duracao)
    {
        Numero = numero;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Numero { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"Episódio {Numero}: {Titulo} ({Duracao}s) - Convidados: {string.Join(", ", convidados)}";

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}
