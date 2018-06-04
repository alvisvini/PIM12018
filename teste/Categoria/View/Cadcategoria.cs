using System;
using System.Windows.Forms;

namespace MiniPack.Categoria.View
{
    public partial class Cadcategoria : MetroFramework.Forms.MetroForm
    {
        public Cadcategoria()
        {
            InitializeComponent();
            LimparCampos();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Model.Categoria categ = new Model.Categoria();
            categ.Descricao = tbDescricao.Text.ToUpper();
            Controller.Categoriacontroller control = new Controller.Categoriacontroller();
            control.Insert(categ);
            LimparCampos();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            tbDescricao.Text = "";
            tbSeq.Text = "";
            Controller.Categoriacontroller control = new Controller.Categoriacontroller();
            dataGridView1.DataSource = control.GetCategorias();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            Model.Categoria categ = new Model.Categoria();
            categ.Seq = Convert.ToInt16(tbSeq.Text);
            Controller.Categoriacontroller control = new Controller.Categoriacontroller();
            control.Delete(categ);
            LimparCampos();
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSeq.Text))
            {
                MessageBox.Show("Informe o Seq", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Model.Categoria c = new Model.Categoria();
            Controller.Categoriacontroller control = new Controller.Categoriacontroller();
            c = control.Pesquisar(Convert.ToInt16(tbSeq.Text));
            if (c == null)
            {
                MessageBox.Show("Categoria nao encontrada!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tbSeq.Text = c.Seq.ToString();
            tbDescricao.Text = c.Descricao;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seq = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            Controller.Categoriacontroller control = new Controller.Categoriacontroller();
            Model.Categoria categ = new Model.Categoria();
            categ = control.Pesquisar(seq);
            tbSeq.Text = categ.Seq.ToString();
            tbDescricao.Text = categ.Descricao;
        }
    }
}
