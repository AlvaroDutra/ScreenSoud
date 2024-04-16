using ScreenSoud.Modelos;

namespace ScreenSoud.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTitulo("Avaliar álbum");
        Console.Write("Digite o nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Nome do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.albums.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.albums.First(a => a.Nome.Equals(tituloAlbum));
                Console.WriteLine($"\n{tituloAlbum}");
                Console.Write("Nota:");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AddNota(nota);
                Console.WriteLine($"Nota {nota.Nota} para {tituloAlbum}.");
            }
            else
            {
                Console.WriteLine($"\n{tituloAlbum} não foi encontrado :(");
            }
  
        }
        else
        {
            Console.WriteLine($"\n{nomeDaBanda} não foi encontrada :(");
        };

    }
}
