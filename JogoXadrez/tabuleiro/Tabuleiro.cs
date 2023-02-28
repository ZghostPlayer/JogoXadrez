namespace JogoXadrez.tabuleiro
{
    class Tabuleiro
    {
        public int linha { get; set; }
        public int colunas { get; set; }
        private  Peca[,] pecas;

        public Tabuleiro( int linha, int colunas)
        {
            this.linha = linha;
            this.colunas = colunas;
            this.pecas = new Peca[linha, colunas];
        }
    }
}
