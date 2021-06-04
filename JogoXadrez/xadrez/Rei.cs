using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {

       
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public Tabuleiro Tab { get; }

        public override string ToString()
        {
            return "R";
        }
    }
}
