using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarCantor : Menu
{
    public override void Executar(Dictionary<string, Cantor> cantoresRegistrados)
    {
        base.Executar(cantoresRegistrados);
        ExibirTituloDaOpcao("Registro de cantores(a)");
        Console.Write("Digite o nome do(a) cantor(a) que deseja registrar: ");
        string nomeDoCantor = Console.ReadLine()!;
        Cantor cantor = new Cantor(nomeDoCantor);
        cantoresRegistrados.Add(nomeDoCantor, cantor);
        Console.WriteLine($"O(a) Cantor(a) {nomeDoCantor} foi registrado(a) com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}