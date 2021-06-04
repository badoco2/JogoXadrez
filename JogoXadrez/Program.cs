using System;
using tabuleiro;
using xadrez;

namespace JogoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 9));
                Tela.imprimeTabuleiro(tab);
            }
            catch (TabuleiroExeception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}
