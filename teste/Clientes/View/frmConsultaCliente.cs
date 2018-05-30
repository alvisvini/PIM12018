using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MiniPack.Clientes.control;

namespace MiniPack.Clientes.View
{
    public partial class frmConsultaCliente : MetroForm
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        private void Pesquisar_Click_1(object sender, EventArgs e)
        {
            ClienteController control = new ClienteController();
            dataGridView1.DataSource = control.GetClientes(textBox1.Text);
        }
    }
}
