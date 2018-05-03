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

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
