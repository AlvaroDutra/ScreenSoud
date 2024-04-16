
using ScreenSoud.Modelos;

namespace ScreenSoud.Menus;

internal class MenuRegistrarAlbum: Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas) 
    {
        ExibirTitulo("Registrar Álbuns");
        Console.Write("Nome da banda: ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.Write("Nome do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Banda banda = bandasRegistradas[nomeBanda];
            banda.AddAlbum(new Album(tituloAlbum)); ;
            Console.WriteLine($"\nO álbum {tituloAlbum} de {nomeBanda} foi registrado com sucesso!");
        }
        else
        {
            Console.WriteLine($"{nomeBanda} não foi encontrada.");
        }
    }
}
