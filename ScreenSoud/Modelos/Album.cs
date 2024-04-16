namespace ScreenSoud.Modelos;

internal class Album: IAvaliavel
{
    public Album(string nome)
    {
        Nome = nome;
    }

    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new ();
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public double Media
    {
        get {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    
    }

    public void AddNota(Avaliacao nota) 
    {
        notas.Add(nota);
    
    }
    public void AddMusica(Musica musica) 
    { 
        musicas.Add(musica);
    }

    public void ListarMusicas()
    {
        Console.WriteLine($"{Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($".{musica.Nome}");
        }
        Console.WriteLine($"\nDuração total do album: {DuracaoTotal} segundos.\n");
    }


}