namespace MiniPack.Categoria.View
{
    partial class Cadcategoria
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
            this.tbDescricao = new MetroFramework.Controls.MetroTextBox();
            this.Limpar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSeq = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDescricao
            // 
            this.tbDescricao.BackColor = System.Drawing.Color.White;
            this.tbDescricao.CustomBackground = true;
            this.tbDescricao.Location = new System.Drawing.Point(142, 82);
            this.tbDescricao.MaxLength = 250;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(330, 23);
            this.tbDescricao.TabIndex = 3;
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Limpar.FlatAppearance.BorderSize = 0;
            this.Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpar.Image = global::MiniPack.Properties.Resources.icons8_clear_formatting_24;
            this.Limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Limpar.Location = new System.Drawing.Point(130, 123);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(81, 46);
            this.Limpar.TabIndex = 25;
            this.Limpar.Text = "Limpar";
            this.Limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Limpar.UseVisualStyleBackColor = false;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Excluir.FlatAppearance.BorderSize = 0;
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excluir.Image = global::MiniPack.Properties.Resources.icons8_cancel_24;
            this.Excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Excluir.Location = new System.Drawing.Point(304, 123);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(81, 46);
            this.Excluir.TabIndex = 24;
            this.Excluir.Text = "Excluir";
            this.Excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salvar.FlatAppearance.BorderSize = 0;
            this.Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salvar.Image = global::MiniPack.Properties.Resources.icons8_mais_24;
            this.Salvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Salvar.Location = new System.Drawing.Point(217, 123);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(81, 46);
            this.Salvar.TabIndex = 23;
            this.Salvar.Text = "Salvar";
            this.Salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Descrição Categoria";
            // 
            // tbSeq
            // 
            this.tbSeq.BackColor = System.Drawing.Color.White;
            this.tbSeq.CustomBackground = true;
            this.tbSeq.Location = new System.Drawing.Point(44, 82);
            this.tbSeq.MaxLength = 250;
            this.tbSeq.Name = "tbSeq";
            this.tbSeq.Size = new System.Drawing.Size(88, 23);
            this.tbSeq.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "SEQ";
            // 
            // Pesquisar
            // 
            this.Pesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pesquisar.FlatAppearance.BorderSize = 0;
            this.Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pesquisar.Image = global::MiniPack.Properties.Resources.icons8_search_24;
            this.Pesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pesquisar.Location = new System.Drawing.Point(391, 123);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(81, 46);
            this.Pesquisar.TabIndex = 28;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Pesquisar.UseVisualStyleBackColor = false;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
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
            this.DESCRICAO});
            this.dataGridView1.Location = new System.Drawing.Point(23, 186);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(451, 193);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SEQ
            // 
            this.SEQ.DataPropertyName = "SEQ";
            this.SEQ.HeaderText = "Seq";
            this.SEQ.Name = "SEQ";
            this.SEQ.ReadOnly = true;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "Descricao";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            // 
            // Cadcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 410);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.tbSeq);
            this.Controls.Add(this.tbDescricao);
            this.Name = "Cadcategoria";
            this.Text = "Cadastro de Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbDescricao;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox tbSeq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
    }
}