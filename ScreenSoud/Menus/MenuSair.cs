﻿using ScreenSoud.Modelos;

namespace ScreenSoud.Menus;

internal class MenuSair: Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas) 
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
