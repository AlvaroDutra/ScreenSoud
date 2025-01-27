﻿namespace ScreenSoud.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota) 
    {
        if (nota <= 0) nota = 0;
        if (nota >= 5) nota = 5; 
        Nota = nota;
    }
    public int Nota { get;  }

    public static Avaliacao Parse (string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota); 
    }

}
