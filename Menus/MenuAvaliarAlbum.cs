using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Cantor> cantoresRegistrados)
    {
        base.Executar(cantoresRegistrados);
        ExibirTituloDaOpcao("Avaliar álbum");
        Console.Write("Digite o nome do(a) cantor(a) que deseja avaliar: ");
        string nomeDoCantor = Console.ReadLine()!;

        if (cantoresRegistrados.ContainsKey(nomeDoCantor))
        {
            Cantor cantor = cantoresRegistrados[nomeDoCantor];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (cantor.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = cantor.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual a nota que o álbum {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso ao álbum {tituloAlbum}");
                Thread.Sleep(1000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO álbum {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
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
