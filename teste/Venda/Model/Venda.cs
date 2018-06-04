using System;

namespace MiniPack.Venda.Model
{
    public class Venda
    {
        private int seqVenda;
        private DateTime dtaVenda;
        private int seqCliente;
        private decimal qtdeItens;
        private decimal vlrTotal;

        public Venda()
        { }

        public int SeqVenda { get => seqVenda; set => seqVenda = value; }
        public DateTime DtaVenda { get => dtaVenda; set => dtaVenda = value; }
        public int SeqCliente { get => seqCliente; set => seqCliente = value; }
        public decimal QtdeItens { get => qtdeItens; set => qtdeItens = value; }
        public decimal VlrTotal { get => vlrTotal; set => vlrTotal = value; }
    }
}
