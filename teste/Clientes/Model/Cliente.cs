namespace MiniPack.Clientes.model
{
    public class Cliente
    {
        private int seq;
        private string nomeRazao;

        public Cliente() { }

        public int Seq { get => seq; set => seq = value; }
        public string NomeRazao { get => nomeRazao; set => nomeRazao = value; }
    }
}


