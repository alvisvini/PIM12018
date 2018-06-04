using System;
using MetroFramework.Forms;
using MiniPack.Venda.Controller;

namespace MiniPack.Venda.View
{
    public partial class frmConsultaVenda : MetroForm
    {
        public frmConsultaVenda()
        {
            InitializeComponent();
        }

        private void frmConsultaVenda_Load(object sender, EventArgs e)
        {

        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            VendaController control = new VendaController();
            dataGridView1.DataSource = control.GetVendas();
        }
    }
}
