using MiniPack.Produto.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
