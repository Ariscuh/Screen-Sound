using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarCantor : Menu
{
    public override void Executar(Dictionary<string, Cantor> cantoresRegistrados)
    {
        base.Executar(cantoresRegistrados);
        ExibirTituloDaOpcao("Avaliar cantor(a)");
        Console.Write("Digite o nome do(a) cantor(a) que deseja avaliar: ");
        string nomeDoCantor = Console.ReadLine()!;
        if (cantoresRegistrados.ContainsKey(nomeDoCantor))
        {
            Cantor cantor = cantoresRegistrados[nomeDoCantor];
            Console.Write($"Qual a nota que o(a) cantor(a) {nomeDoCantor} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            cantor.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o(a) cantor(a) {nomeDoCantor}");
            Thread.Sleep(2000);
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nO(a) cantor(a) {nomeDoCantor} não foi encontrado(a)!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
