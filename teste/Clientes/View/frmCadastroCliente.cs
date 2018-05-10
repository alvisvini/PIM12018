using MiniPack.Clientes.control;
using MiniPack.Clientes.model;
using System;
using System.Windows.Forms;

namespace teste
{
    public partial class frmCadastroCliente : MetroFramework.Forms.MetroForm
    {
        public frmCadastroCliente()
        {
            InitializeComponent();


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = file.FileName;
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Cliente p = new Cliente();
            p.NomeRazao = tbDescricao.Text.ToUpper();
            ClienteController control = new ClienteController();
            if(control.Insert(p))
            {
                MessageBox.Show("Sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbSeq.Text))
            {
                MessageBox.Show("Informe o Seq", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cliente p = new Cliente();
            p.Seq = Convert.ToInt16(tbSeq.Text);
            ClienteController control = new ClienteController();
            if (control.Delete(p))
            {
                MessageBox.Show("Sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            tbSeq.Text = "";
            tbDescricao.Text = "";
           
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSeq.Text))
            {
                MessageBox.Show("Informe o Seq", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cliente p = new Cliente();
            ClienteController control = new ClienteController();
            p = control.Pesquisar(Convert.ToInt16(tbSeq.Text));
            if(p == null)
            {
                MessageBox.Show("Cliente nao encontrado!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tbDescricao.Text = p.NomeRazao;
           
        }
    }
}
