using JogoXadrez;
using JogoXadrez.tabuleiro;
using JogoXadrez.xadrez;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 9));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
        catch(TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadLine() ;
    }
}