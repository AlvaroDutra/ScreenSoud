using ScreenSoud.Menus;
using ScreenSoud.Modelos;





Banda pinkFloyd = new("Pink Floyd");

pinkFloyd.AddNota(new Avaliacao(5));
pinkFloyd.AddNota(new Avaliacao(3));


Banda gunsNRoses = new ("Guns N' Roses");

gunsNRoses.AddNota(new Avaliacao(5));
gunsNRoses.AddNota(new Avaliacao(3));


Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(pinkFloyd.Nome, pinkFloyd);
bandasRegistradas.Add(gunsNRoses.Nome, gunsNRoses);

Dictionary<int, Menu> opcoes = [];
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuMostrarBanda());
opcoes.Add(3, new MenuAvaliarBanda());
opcoes.Add(4, new MenuDetalhes());
opcoes.Add(5, new MenuRegistrarAlbum());
opcoes.Add(6, new MenuAvaliarAlbum());
opcoes.Add(7, new MenuSair());



void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir detalhes de uma banda");
    Console.WriteLine("Digite 5 para registrar um álbum à uma banda");
    Console.WriteLine("Digite 6 para avaliar um álbum de uma banda");
    Console.WriteLine("Digite 7 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuExibido = opcoes[opcaoEscolhidaNumerica];
        menuExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica < 7) VoltarMenu();
    }
    else {
        Console.WriteLine("Opção inválida");
    }
    
}
void VoltarMenu()
{
    Console.WriteLine("\nAperte enter para retornar ao menu.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
};

ExibirOpcoesDoMenu();