using ScreenSoud.Modelos;

namespace ScreenSoud.Menus;

internal class MenuDetalhes: Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        ExibirTitulo("Detalhes da Banda");
        Console.Write("Nome da banda: ");
        string nomeBanda = Console.ReadLine()!;
        
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];
            //Console.WriteLine(banda.Resumo);
            Console.WriteLine($"\nNota de {nomeBanda}: {banda.Media}");
            foreach (Album album in banda.albums)
            {
                Console.WriteLine($".{album.Nome}: {album.Media}");
            }

        }
        else
        {
            Console.WriteLine($"\n{nomeBanda} não foi encontrada :(");
        };
        
    }
}
