using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Cantor> cantoresRegistrados)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
