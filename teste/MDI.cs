using MiniPack;
using MiniPack.Categoria.View;
using MiniPack.Clientes.View;
using MiniPack.Venda.View;
using System;
using System.Windows.Forms;

namespace teste
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        ~MDI()
        {
            Banco.Close();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f1 = new frmCadastroProduto();
            f1.MdiParent = this;
            f1.Show();
        }

        private void btnConsProduto_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f2 = new frmConsultaProduto();
            f2.MdiParent = this;
            f2.Show();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f2 = new frmCadastroCliente();
            f2.MdiParent = this;
            f2.Show();
        }

        private void btnCAdCategoria(object sender, EventArgs e)
        {
            Cadcategoria f2 = new Cadcategoria();
            f2.MdiParent = this;
            f2.Show();
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            Venda v = new Venda();
            v.MdiParent = this;
            v.Show();
        }

        private void btnConsCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f2 = new frmConsultaCliente ();
            f2.MdiParent = this;
            f2.Show();
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            frmConsultaVenda f2 = new frmConsultaVenda();
            f2.MdiParent = this;
            f2.Show();
        }
    }
}
