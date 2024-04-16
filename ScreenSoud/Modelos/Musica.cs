namespace ScreenSoud.Modelos;

internal class Musica 
{
    public Musica(Banda artista, string nome) 
    { 
        Artista = artista;
        Nome = nome;
    }


    public string Nome {  get; }
    public Banda Artista { get; }
    public int Duracao {  get; set; }
    public bool Disponivel {  get; set; }
    public string Descricao => $"A música {Nome} pertence à {Artista}";


    public void ExibirFichaTecnica() {

        Console.WriteLine("Música");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} seg");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no seu plano.\n");
        }else
        {
            Console.WriteLine("Adquira o plano Plus para ter acesso.\n");
        }
        
    }

    public void NomeEArtista()
    {
        Console.WriteLine($"Nome da música: {Nome}\nNome do artista: {Artista}");

    }

    


}