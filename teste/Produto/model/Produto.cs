namespace MiniPack.Produto.model
{
    public class Produto
    {
        private int seq;
        private string desc;
        private string marca;
        private string categoria;
        private string obs;

        public Produto() { }

        public int Seq { get => seq; set => seq = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Obs { get => obs; set => obs = value; }
    }
}


