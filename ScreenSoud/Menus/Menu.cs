
using ScreenSoud.Modelos;

namespace ScreenSoud.Menus;

internal class Menu
{
    public void ExibirTitulo(string titulo)
    {
       Console.Clear();
       Console.WriteLine($"{titulo}\n");

    }

    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        
    }
}
