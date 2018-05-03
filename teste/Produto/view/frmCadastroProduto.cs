using MiniPack.Produto.control;
using MiniPack.Produto.model;
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
    public partial class frmCadastroProduto : MetroFramework.Forms.MetroForm
    {
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
            p.Desc = tbDescricao.Text.ToUpper();
            p.Marca = tbMarca.Text.ToUpper();
            p.Obs = tbObs.Text.ToUpper();
            ProdutoController control = new ProdutoController();
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
            Produto p = new Produto();
            p.Seq = Convert.ToInt16(tbSeq.Text);
            ProdutoController control = new ProdutoController();
            if (control.Delete(p))
            {
                MessageBox.Show("Sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            ProdutoController control = new ProdutoController();
            categoria.DataSource = control.GetCategorias();

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            tbSeq.Text = "";
            tbDescricao.Text = "";
            tbMarca.Text = "";
            tbObs.Text = "";
            
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
            tbDescricao.Text = p.Desc;
            tbMarca.Text = p.Marca;
            tbObs.Text = p.Obs;
            
        }
    }
}
