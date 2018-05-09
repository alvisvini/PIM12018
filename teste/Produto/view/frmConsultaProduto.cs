using MiniPack.Produto.control;
using System;

namespace teste
{
    public partial class frmConsultaProduto : MetroFramework.Forms.MetroForm
    {
        public frmConsultaProduto()
        {
            InitializeComponent();


        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            ProdutoController control = new ProdutoController();
            dataGridView1.DataSource = control.GetProdutos(textBox1.Text);
        }
    }
}
