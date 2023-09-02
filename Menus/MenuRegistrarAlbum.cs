using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Cantor> cantoresRegistrados)
    {
        base.Executar(cantoresRegistrados);
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite o(a) Cantor(a) cujo álbum deseja registrar: ");
        string nomeDoCantor = Console.ReadLine()!;
        if (cantoresRegistrados.ContainsKey(nomeDoCantor))
        {
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Cantor cantor = cantoresRegistrados[nomeDoCantor];
            cantor.AdicionarAlbum(new Album(tituloAlbum));
            /**
             * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
             */
            Console.WriteLine($"O álbum {tituloAlbum} de {nomeDoCantor} foi registrado com sucesso!");
            Thread.Sleep(4000);
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
