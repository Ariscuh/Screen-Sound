using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{

    public override void Executar(Dictionary<string, Cantor> cantoresRegistrados)
    {
        base.Executar(cantoresRegistrados);
        ExibirTituloDaOpcao("Exibir detalhes do(a) cantor(a)");
        Console.Write("Digite o nome do(a) cantor(a) que deseja conhecer melhor: ");
        string nomeDoCantor = Console.ReadLine()!;
        if (cantoresRegistrados.ContainsKey(nomeDoCantor))
        {
            Cantor cantor = cantoresRegistrados[nomeDoCantor];
            Console.WriteLine($"\nA média do(a) cantor(a) {nomeDoCantor} é {cantor.Media}.");
            /**
            * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
            */
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nO(a) cantor(a) {nomeDoCantor} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
