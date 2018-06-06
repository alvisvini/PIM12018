using MiniPack.Produto.control;
using MiniPack.Produto.model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace teste
{
    public partial class frmCadastroProduto : MetroFramework.Forms.MetroForm
    {
        private bool carregado = false;
        private string urlImagem = Directory.GetCurrentDirectory() + "\\unavailable.png";

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
                pbImagem.ImageLocation = file.FileName;
                urlImagem = file.FileName;
            }

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbDescricao.Text) && (!string.IsNullOrEmpty(tbMarca.Text) && (!string.IsNullOrEmpty(tbCodigo.Text))) && categoria.SelectedIndex >= 0)
            {
                Produto p = new Produto();
                if (!string.IsNullOrEmpty(tbSeq.Text))
                    p.Seq = Convert.ToUInt16(tbSeq.Text);
                p.Desc = tbDescricao.Text.ToUpper();
                p.Marca = tbMarca.Text.ToUpper();
                p.Obs = tbObs.Text.ToUpper();
                p.Seqcategoria = Convert.ToInt16(categoria.SelectedValue);
                p.Preco = tbPreco.Value;
                p.Tamanho = Convert.ToInt32(tbTamanho.Value);
                p.Imagem = urlImagem;
                p.Quantidade = Convert.ToInt16(tbEsqtoque.Value);
                p.Cod = tbCodigo.Text;                

                ProdutoController control = new ProdutoController();

                if (carregado == false)
                {
                    if (control.Insert(p))
                    {
                        MessageBox.Show("Produto inserido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (control.Update(p))
                    {
                        MessageBox.Show("Produto atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                limpaTela();
            }
            else
            {
                MessageBox.Show("Dados incompletos. Verifique os campos:\n\n - Descricao\n - Marca\n - Codigo\n - Categoria", "ATENCAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = tbDescricao;
                tbDescricao.Focus();
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
            limpaTela();
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
            tbPreco.Value = 0;
            tbTamanho.Value = 0;
            tbCodigo.Text = "";
            pbImagem.Image = MiniPack.Properties.Resources.unavailable;
            urlImagem = Directory.GetCurrentDirectory() + "\\unavailable.png";
            tbEsqtoque.Value = 0;
            tbCodigo.Text = "";
            carregado = false;
            categoria.DisplayMember = "DESCRICAO";
            categoria.ValueMember = "SEQ";
            ProdutoController control = new ProdutoController();
            categoria.DataSource = control.GetCategorias();
            categoria.SelectedIndex = -1;
            carregado = false;
            pbImagem.Image = MiniPack.Properties.Resources.unavailable;
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodigo.Text))
            {
                MessageBox.Show("Informe o Codigo", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Produto p = new Produto();
            ProdutoController control = new ProdutoController();
            p = control.Pesquisar(tbCodigo.Text);
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
            tbPreco.Value = p.Preco;
            tbTamanho.Value = p.Tamanho;
            pbImagem.Image = MiniPack.Properties.Resources.unavailable;
            pbImagem.ImageLocation = p.Imagem;
            tbEsqtoque.Value = p.Quantidade;
            tbCodigo.Text = p.Cod;
            carregado = true;
        }

     }
    }

