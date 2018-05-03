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

        private void ribbon1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
