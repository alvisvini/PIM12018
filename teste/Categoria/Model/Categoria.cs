namespace MiniPack.Categoria.Model
{
    public class Categoria
        
    {
        private int seq;
        private string descricao;

        public Categoria() { }

        public int Seq { get => seq; set => seq = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
