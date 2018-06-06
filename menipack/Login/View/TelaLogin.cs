using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste;

namespace MiniPack.Login.View
{
    public partial class TelaLogin : MetroFramework.Forms.MetroForm
    {
        public TelaLogin()
        {
            InitializeComponent();
            Banco.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        
        private void Entrar()
        {            
            Clientes.control.ClienteController control = new Clientes.control.ClienteController();
            if(control.getSenha(tbFuncionario.Text) == tbSenha.Text && !string.IsNullOrEmpty(tbFuncionario.Text) && !string.IsNullOrEmpty(tbSenha.Text))
            {
                this.Visible = false;
                MDI mdi = new MDI();
                mdi.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbFuncionario.Text = "";
                tbSenha.Text = "";
            }
            
        }

        ~TelaLogin()
        {
            Banco.Close();
        }
    }
}
