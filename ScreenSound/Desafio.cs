class Podcast
{
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;
    public List<Episodio> episodios = new();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpidodio(Episodio ep)
    {
        episodios.Add(ep);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Bem vindo ao {Nome} com {Host}\n");
        Console.WriteLine("Segue a lista de episódios\n");
        foreach (Episodio ep in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(ep.Resumo);
        }
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
    }
}

class Episodio
{
    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - " +
        $"{string.Join(", ", convidados)}";
    private List<string> convidados = new();

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}