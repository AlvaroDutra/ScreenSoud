namespace ScreenSoud.Modelos;

internal class Banda : IAvaliavel
{

    public Banda(string nome)
    { 
        Nome = nome;
    }  

    private List<Avaliacao> notas = [];
    public IEnumerable<Album> albums => albums;
    
    public string Nome {  get; }
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }  
    }
    //public string? Resumo { get; set; }



    public void AddAlbum(Album album)
    {
        albums.Append(album);
    }
    public void AddNota(Avaliacao nota) 
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda '{Nome}'");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} - {album.DuracaoTotal} segundos\n");
        }
    }



}
