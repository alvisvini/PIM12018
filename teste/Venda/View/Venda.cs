using MiniPack.Clientes.control;
using MiniPack.Produto.control;
using MiniPack.Venda.Controller;
using MiniPack.Venda.Model;
using System;
using System.IO;
using System.Windows.Forms;
using teste;

namespace MiniPack.Venda.View
{
    public partial class Venda : MetroFramework.Forms.MetroForm
    {
        private decimal qtdeItens = 0;
        public Venda()
        {
            InitializeComponent();
        }

        private void Venda_Load(object sender, System.EventArgs e)
        {
            Limpar();
        }

        private void btnBuscarProduto_Click(object sender, System.EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            if (string.IsNullOrEmpty(tbCodigo.Text))
            {
                return;
            }
            MiniPack.Produto.model.Produto p = new MiniPack.Produto.model.Produto();
            ProdutoController control = new ProdutoController();
            p = control.Pesquisar(tbCodigo.Text);
            if (p == null)
            {
                MessageBox.Show("Produto nao encontrado");
                tbCodigo.Text = "";
                tbDescricao.Text = "";
                tbVlrUnit.Text = "";
                return;
            }
            tbSeq.Text = p.Seq.ToString();
            tbCodigo.Text = p.Cod;
            tbDescricao.Text = p.Desc;
            tbVlrUnit.Text = p.Preco.ToString("0.00");
            tbQtdeEstq.Text = p.Quantidade.ToString();
            pbImagem.ImageLocation = p.Imagem;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal vlrUnitario = Convert.ToDecimal(tbVlrUnit.Text);
            decimal qtde = tbQtde.Value;
            decimal vlrTotal = vlrUnitario * qtde;
            decimal vlrEstq = Convert.ToDecimal(tbQtdeEstq.Text);
            if(qtde > vlrEstq)
            {
                MessageBox.Show("Quantidade informada insuficiente no estoque.", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            tblItens.Rows.Add(tbSeq.Text, tbCodigo.Text, tbDescricao.Text, tbQtde.Value.ToString("0.00"), tbVlrUnit.Text, vlrTotal.ToString("0.00"));
            calcula();
        }

        private void calcula()
        {
            decimal total = 0;
            for (int i = 0; i < tblItens.Rows.Count; i++)
            {
                total += Convert.ToDecimal(tblItens.Rows[i].Cells["SUBTOTALITEM"].Value);
                qtdeItens += Convert.ToDecimal(tblItens.Rows[i].Cells["QTDE"].Value);
            }
            tbTotalVenda.Text = total.ToString("0.00");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tblItens.Rows.Count > 0)
            {
                tblItens.Rows.Remove(tblItens.CurrentRow);
                calcula();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            tbCodigo.Text = "";
            tbSeq.Text = "";
            tbDescricao.Text = "";
            tbVlrUnit.Text = "";
            tbQtde.Value = 1;
            tbSeqVenda.Text = "";
            tbCpf.Text = "";
            tbNomeRazao.Text = "";
            tbSeqCliente.Text = "";

            for (int i = 0; i < tblItens.Rows.Count; i++)
                tblItens.Rows.Remove(tblItens.Rows[i]);

            tbTotalVenda.Text = "0,00";
            qtdeItens = 0;
            pbImagem.ImageLocation = Directory.GetCurrentDirectory() + "\\unavailable.png";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MiniPack.Venda.Model.Venda venda = new Model.Venda();
            if (!string.IsNullOrEmpty(tbSeqCliente.Text))
                venda.SeqCliente = Convert.ToUInt16(tbSeqCliente.Text);
            venda.DtaVenda = DateTime.Now;
            venda.QtdeItens = qtdeItens;
            venda.VlrTotal = Convert.ToDecimal(tbTotalVenda.Text);
            VendaController controlVenda = new VendaController();
            controlVenda.Insert(venda);
            int seqVenda = controlVenda.getMaxSeqVenda();
            for(int i = 0; i < tblItens.Rows.Count; i++)
            {
                VendaItem item = new VendaItem();
                item.SeqVenda = seqVenda;
                item.SeqProduto = Convert.ToInt16(tblItens.Rows[i].Cells["SEQ"].Value);
                item.VlrProduto = Convert.ToDecimal(tblItens.Rows[i].Cells["VLRUNITARIO"].Value);
                item.Qtde = Convert.ToDecimal(tblItens.Rows[i].Cells["QTDE"].Value);
                item.VlrSubtotal = Convert.ToDecimal(tblItens.Rows[i].Cells["SUBTOTALITEM"].Value);
                VendaItemController controlVendaItem = new VendaItemController();
                controlVendaItem.Insert(item);
            }
            Limpar();
        }

        private void tbCodigo_Validated(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f2 = new frmConsultaProduto();
            f2.ShowDialog();
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSeqVenda.Text))
            {
                MessageBox.Show("Informe o Seq", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Model.Venda p = new Model.Venda();
            VendaController control = new VendaController();
            p = control.GetVenda(Convert.ToInt16( tbSeqVenda.Text));
            if (p == null)
            {
                MessageBox.Show("Venda não encontrada!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tbSeqVenda.Text = p.SeqVenda.ToString();
            tbTotalVenda.Text = p.VlrTotal.ToString();

            VendaItemController control2 = new VendaItemController();
            tblItens.DataSource = control2.GetVendaItens(Convert.ToInt16(tbSeqVenda.Text));


        }

        private void tbSeqVenda_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCpf.Text))
            {
                return;
            }
            MiniPack.Clientes.model.Cliente c = new Clientes.model.Cliente();
            ClienteController control = new ClienteController();
            c = control.PesquisarCPF(tbCpf.Text);
            if (c == null)
            {
                MessageBox.Show("Cliente nao encontrado");
                tbCpf.Text = "";
                tbNomeRazao.Text = "";
                return;
            }
            tbNomeRazao.Text = c.NomeRazao;
            tbSeqCliente.Text = c.Seq.ToString();
        }
    }
}
