
using System;
using MetroFramework.Forms;

namespace MiniPack.Categoria.View
{
    public partial class Cadcategoria : MetroForm
    {
        public Cadcategoria()
        {
            InitializeComponent();
        }


        private void Salvar_Click(object sender, System.EventArgs e)
        {
            Cadcategoria p = Categoria();
            p.
             = tbDescricao.Text.ToUpper();
            categoriaController control = Categoriacontroller();
            if (control.Insert(p))
            {
                MessageBox.Show("Sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private Cadcategoria Categoria()
        {
            throw new NotImplementedException();
        }
    }
}
