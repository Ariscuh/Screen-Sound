using ScreenSound.Menus;
using ScreenSound.Modelos;

Cantor derek = new("Derek");
derek.AdicionarNota(new Avaliacao(10));
derek.AdicionarNota(new Avaliacao(8));
derek.AdicionarNota(new Avaliacao(6));
Cantor veigh = new("Veigh");

Dictionary<string, Cantor> cantoresRegistrados = new();
cantoresRegistrados.Add(derek.Nome, derek);
cantoresRegistrados.Add(veigh.Nome, veigh);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarCantor());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarCantoresRegistrados());
opcoes.Add(4, new MenuAvaliarCantor());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗   ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║   ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║   ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║   ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║   ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝   ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um(a) cantor(a)");
    Console.WriteLine("Digite 2 para registrar o álbum de um(a) cantor(a)");
    Console.WriteLine("Digite 3 para mostrar todas os cantores(a)");
    Console.WriteLine("Digite 4 para avaliar um cantor(a)");
    Console.WriteLine("Digite 5 para exibir os detalhes de um(a) cantor(a)");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuDeExibicao = opcoes[opcaoEscolhidaNumerica];
        menuDeExibicao.Executar(cantoresRegistrados);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }

}


ExibirOpcoesDoMenu();