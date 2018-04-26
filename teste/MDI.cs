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

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f1 = new frmCadastroProduto();
            f1.MdiParent = this;
            f1.Show();
        }
        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f1 = new frmConsultaProduto();
            f1.MdiParent = this;
            f1.Show();
        }
        private void ribbon1_Click(object sender, EventArgs e)
        {
                    }
    }
}
