using ScreenSoud.Modelos;

namespace ScreenSoud.Menus;

internal class MenuAvaliarBanda : Menu
{
    

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        ExibirTitulo("Avaliar Banda");
        Console.Write("Digite o nome da banda que deseje avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\n{nomeDaBanda}");
            Console.Write("Nota (0 a 5):");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AddNota(nota);
            Console.WriteLine($"Nota {nota.Nota} para {nomeDaBanda}.");

        }
        else
        {
            Console.WriteLine($"\n{nomeDaBanda} não foi encontrada :(");
        };

    }


}
