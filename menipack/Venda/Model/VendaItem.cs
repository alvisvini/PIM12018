namespace MiniPack.Venda.Model
{
    public class VendaItem
    {
        private int seqVendaItem;
        private int seqVenda;
        private int seqProduto;
        private decimal qtde;
        private decimal vlrProduto;
        private decimal vlrSubtotal;

        public VendaItem()
        { }

        public int SeqVendaItem { get => seqVendaItem; set => seqVendaItem = value; }
        public int SeqProduto { get => seqProduto; set => seqProduto = value; }
        public decimal Qtde { get => qtde; set => qtde = value; }
        public decimal VlrProduto { get => vlrProduto; set => vlrProduto = value; }
        public decimal VlrSubtotal { get => vlrSubtotal; set => vlrSubtotal = value; }
        public int SeqVenda { get => seqVenda; set => seqVenda = value; }
    }
}
