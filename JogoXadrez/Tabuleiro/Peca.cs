
namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.qtdMovimento = 0;
            this.tab = tab;
        }

        protected Peca(Tabuleiro tab, Cor cor)
        {
            this.tab = tab;
            this.cor = cor;
        }
    }
}
