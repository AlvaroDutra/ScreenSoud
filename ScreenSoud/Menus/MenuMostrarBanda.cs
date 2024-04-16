using ScreenSoud.Modelos;

namespace ScreenSoud.Menus;

internal class MenuMostrarBanda: Menu
{
    public override void Executar(Dictionary<string , Banda> bandasRegistradas) 
    {
        ExibirTitulo("Lista de Bandas");
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($".{banda}");
        };

    }

}
