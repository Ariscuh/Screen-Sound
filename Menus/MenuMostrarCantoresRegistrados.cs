using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarCantoresRegistrados : Menu
{
    public override void Executar(Dictionary<string, Cantor> cantoresRegistrados)
    {
        base.Executar(cantoresRegistrados);
        ExibirTituloDaOpcao("Exibindo todos os cantores registrados na nossa aplicação");

        foreach (string cantor in cantoresRegistrados.Keys)
        {
            Console.WriteLine($"Cantor: {cantor}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

    }
}
