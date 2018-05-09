namespace MiniPack.Produto.model
{
    public class Produto
    {
        private int seq;
        private string desc;
        private string marca;
        private int seqcategoria;
        private string obs;
        private int preco;

        public Produto() { }

        public int Seq { get => seq; set => seq = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Seqcategoria { get => seqcategoria; set => seqcategoria = value; }
        public string Obs { get => obs; set => obs = value; }
        public int Preco { get => preco; set => preco = value; }
    }
}


