namespace MiniPack.Produto.model
{
    public class Produto
    {
        private int seq;
        private string desc;
        private string marca;
        private int seqcategoria;
        private string obs;
        private decimal preco;
        private int tamanho;
        private string imagem;

        public Produto() { }

        public int Seq { get => seq; set => seq = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Seqcategoria { get => seqcategoria; set => seqcategoria = value; }
        public string Obs { get => obs; set => obs = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }
        public string Imagem { get => imagem; set => imagem = value; }
    }
}


