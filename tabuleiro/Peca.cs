namespace XadrezConsole.tabuleiro
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Tabuleiro = tabuleiro;
            Cor = cor;
            Posicao = null;
            QtdeMovimentos = 0;
        }

        public void IncrementarQtdMovimentos()
        {
            QtdeMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
