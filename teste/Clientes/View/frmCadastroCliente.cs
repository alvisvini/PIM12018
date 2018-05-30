using MiniPack.Clientes.control;
using MiniPack.Clientes.model;
using System;
using System.Windows.Forms;
using Correios.Net;

namespace teste
{
    public partial class frmCadastroCliente : MetroFramework.Forms.MetroForm
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
            cbTipoPessoa.SelectedIndex = 0;
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
            p.Tipopessoa = cbTipoPessoa.Text;
            p.Cpf = tbcpf.Text.Replace(",","").Replace("-","");
            p.TelCelular = tbcel.Text.Replace(")", "").Replace("(", "").Replace("-", "");
            p.Rg = tbRg.Text.Replace(".","");
            p.TelFixo = TBtelfixo.Text.Replace(")", "").Replace("(", "").Replace("-", "");
            p.DtaNasc = tbnasc.Text;
            p.TelRecado = tbrecado.Text.Replace(")", "").Replace("(", "").Replace("-", "");
            p.Sexo = cmbSexo.Text;
            p.EstadoCivil = cmbEstCivil.Text;
            p.Email = tbEmail.Text;
            p.Id = tbID.Text;
            p.Senha = tbSenha.Text;
            p.Cep = tbCep.Text;
            p.Logradouro = tbLogradouro.Text;
            p.Bairro = tbBairro.Text;
            p.Complemento = tbComplemento.Text;
            p.Nro = Convert.ToInt16(tbNro.Text);
            p.Cidade = tbCidade.Text;
            p.Uf = tbUf.Text;
            p.Pais = tbPais.Text;

            ClienteController control = new ClienteController();
            if (string.IsNullOrEmpty(tbSeq.Text))
            {
                if (control.Insert(p))
                {
                    MessageBox.Show("Inserido com Sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }else
            {
                p.Seq = Convert.ToInt16(tbSeq.Text);
                if (control.Update(p))
                {
                    MessageBox.Show("Atualizado com Sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tbcpf.Text = "";
            tbID.Text = "";
            tbSenha.Text = "";
            tbNomeRazao.Text = "";
            tbcpf.Text = "";
            tbRg.Text = "";
            tbnasc.Text = "";
            cmbSexo.SelectedIndex = 0;
            cmbEstCivil.SelectedIndex = 0;
            tbEmail.Text = "";
            TBtelfixo.Text = "";
            tbrecado.Text = "";
            tbcel.Text = "";
            tbCep.Text = "";
            tbLogradouro.Text = "";
            tbUf.Text = "";
            tbPais.Text = "";
            tbBairro.Text = "";
            tbComplemento.Text = "";
            tbCidade.Text = "";
            tbNro.Text = "";
            cbTipoPessoa.SelectedIndex = 0;
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
            tbSeq.Text = p.Seq.ToString();
            tbDescricao.Text = p.NomeRazao;
            tbcpf.Text = p.Cpf;
            cbTipoPessoa.Text = p.Tipopessoa;
            tbID.Text = p.Id;
            tbSenha.Text = p.Senha;
            tbcpf.Text = p.Cpf;
            tbRg.Text = p.Rg;
            tbnasc.Text = p.DtaNasc;
            cmbSexo.SelectedIndex = 0;
            cmbEstCivil.SelectedIndex = 0;
            tbEmail.Text = p.Email;
            TBtelfixo.Text = p.TelFixo;
            tbrecado.Text = p.TelRecado;
            tbcel.Text = p.TelCelular;
            tbCep.Text = p.Cep;
            tbLogradouro.Text = p.Logradouro;
            tbUf.Text = p.Uf;
            tbPais.Text = p.Pais;
            tbBairro.Text = p.Bairro;
            tbComplemento.Text = p.Complemento;
            tbCidade.Text = p.Cidade;
            tbNro.Text = Convert.ToString(p.Nro);
        }

        private void cbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPessoa.Text != "Cliente")
            {
                if (ab3.TabPages.Contains(metroTabPage3) == false)
                    ab3.TabPages.Add(metroTabPage3);
            }
            else
            {
                this.ab3.TabPages.Remove(metroTabPage3);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCep.Text))

            {

                MessageBox.Show("O CEP inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;

            }

            try

            {

                CEP cep = new CEP(tbCep.Text.ToString().Replace("-", ""));



                if (cep != null)

                {

                    tbUf.Text = cep.uf;

                    tbCidade.Text = cep.localidade;

                    tbBairro.Text = cep.bairro;

                    tbLogradouro.Text = cep.logradouro;

                }

                else

                {

                    MessageBox.Show("O CEP informado não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    tbCep.Text = string.Empty;

                }

            }
            catch (Exception ex)

            {

                MessageBox.Show("O CEP informado não foi encontrado.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
    }
