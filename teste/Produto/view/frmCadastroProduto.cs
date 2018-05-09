using MiniPack.Produto.control;
using MiniPack.Produto.model;
using System;
using System.Windows.Forms;

namespace teste
{
    public partial class frmCadastroProduto : MetroFramework.Forms.MetroForm
    {
        bool carregado = false;

        public frmCadastroProduto()
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
            Produto p = new Produto();
            p.Seq = Convert.ToUInt16(tbSeq.Text);
            p.Desc = tbDescricao.Text.ToUpper();
            p.Marca = tbMarca.Text.ToUpper();
            p.Obs = tbObs.Text.ToUpper();
            p.Seqcategoria = Convert.ToInt16(categoria.SelectedValue);
            p.Preco = Convert.ToInt16(tbPreco.Text);
            ProdutoController control = new ProdutoController();

            if (carregado == false)
            {
                if (control.Insert(p))
                {
                    MessageBox.Show("Produto inserido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
            {
                if (control.Update(p))
                {
                    MessageBox.Show("Produto atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbSeq.Text))
            {
                MessageBox.Show("Informe o Seq", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Produto p = new Produto();
            p.Seq = Convert.ToInt16(tbSeq.Text);
            ProdutoController control = new ProdutoController();
            if (control.Delete(p))
            {
                MessageBox.Show("Produto excluido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaTela();
            }
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            categoria.DisplayMember = "DESCRICAO";
            categoria.ValueMember = "SEQ";
            ProdutoController control = new ProdutoController();
            categoria.DataSource = control.GetCategorias();
            categoria.SelectedIndex = -1;
            carregado = false;
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void limpaTela()
        {
            tbSeq.Text = "";
            tbDescricao.Text = "";
            tbMarca.Text = "";
            tbObs.Text = "";
            categoria.SelectedIndex = -1;
            carregado = false;
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSeq.Text))
            {
                MessageBox.Show("Informe o Seq", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Produto p = new Produto();
            ProdutoController control = new ProdutoController();
            p = control.Pesquisar(Convert.ToInt16(tbSeq.Text));
            if(p == null)
            {
                MessageBox.Show("Produto nao encontrado!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tbSeq.Text = p.Seq.ToString();
            tbDescricao.Text = p.Desc;
            tbMarca.Text = p.Marca;
            tbObs.Text = p.Obs;
            categoria.SelectedValue = p.Seqcategoria;
            carregado = true;
        }
    }
}
