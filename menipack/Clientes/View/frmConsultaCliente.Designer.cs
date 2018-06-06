namespace MiniPack.Clientes.View
{
    partial class frmConsultaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeRazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelFixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEQ,
            this.NomeRazao,
            this.Cpf,
            this.TelCelular,
            this.TelFixo,
            this.Email,
            this.TipoPessoa});
            this.dataGridView1.Location = new System.Drawing.Point(23, 118);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(768, 343);
            this.dataGridView1.TabIndex = 25;
            // 
            // Pesquisar
            // 
            this.Pesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pesquisar.FlatAppearance.BorderSize = 0;
            this.Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pesquisar.Image = global::MiniPack.Properties.Resources.icons8_search_24;
            this.Pesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pesquisar.Location = new System.Drawing.Point(293, 66);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(81, 46);
            this.Pesquisar.TabIndex = 28;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Pesquisar.UseVisualStyleBackColor = false;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click_1);
            // 
            // SEQ
            // 
            this.SEQ.DataPropertyName = "SEQ";
            this.SEQ.HeaderText = "Seq";
            this.SEQ.Name = "SEQ";
            this.SEQ.ReadOnly = true;
            // 
            // NomeRazao
            // 
            this.NomeRazao.DataPropertyName = "NomeRazao";
            this.NomeRazao.HeaderText = "Nome";
            this.NomeRazao.Name = "NomeRazao";
            this.NomeRazao.ReadOnly = true;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            // 
            // TelCelular
            // 
            this.TelCelular.DataPropertyName = "TelCelular";
            this.TelCelular.HeaderText = "Tel. Celular";
            this.TelCelular.Name = "TelCelular";
            this.TelCelular.ReadOnly = true;
            // 
            // TelFixo
            // 
            this.TelFixo.DataPropertyName = "TelFixo";
            this.TelFixo.HeaderText = "Tel. Fixo";
            this.TelFixo.Name = "TelFixo";
            this.TelFixo.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // TipoPessoa
            // 
            this.TipoPessoa.DataPropertyName = "TipoPessoa";
            this.TipoPessoa.HeaderText = "Tipo Pessoa";
            this.TipoPessoa.Name = "TipoPessoa";
            this.TipoPessoa.ReadOnly = true;
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 484);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(473, 408);
            this.Name = "frmConsultaCliente";
            this.Text = "Consulta de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeRazao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelFixo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPessoa;
    }
}