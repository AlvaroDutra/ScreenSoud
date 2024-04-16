using ScreenSoud.Modelos;

namespace ScreenSoud.Menus;

internal class MenuRegistrarBanda: Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas) {
        ExibirTitulo("Registrar Banda");
        Console.Write("Banda: ");
        string nomeBanda = Console.ReadLine()!;
        Banda banda = new(nomeBanda);
        bandasRegistradas.Add(nomeBanda, banda);

        /*
        utilizando ia para escrever um resumo da banda. 
        ps: nao funicona pois a APIKey expirou.

        using OpenAI_API;

        var client = new OpenAIAPI("sk-proj-zw9T8ZzqLWgQeTmF9QnqT3BlbkFJumzlGpLGknH9T2dC8Hgc");

        var chat = client.Chat.CreateConversation();
        chat.AppendSystemMessage($"Resuma a banda {nomeBanda} de forma informal em uma paragrafo.");
        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        banda.Resumo = resposta;
        */

        Console.WriteLine($"{nomeBanda} foi resgistrada com sucesso!");

    }
}
