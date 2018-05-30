namespace MiniPack.Venda.View
{
    partial class frmConsultaVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.SEQVENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTAVENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMERAZAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDEITENS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLRTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEQVENDA,
            this.DTAVENDA,
            this.NOMERAZAO,
            this.QTDEITENS,
            this.VLRTOTAL});
            this.dataGridView1.Location = new System.Drawing.Point(23, 118);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(629, 343);
            this.dataGridView1.TabIndex = 29;
            // 
            // Pesquisar
            // 
            this.Pesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pesquisar.FlatAppearance.BorderSize = 0;
            this.Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pesquisar.Image = global::MiniPack.Properties.Resources.icons8_search_24;
            this.Pesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pesquisar.Location = new System.Drawing.Point(571, 63);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(81, 46);
            this.Pesquisar.TabIndex = 32;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Pesquisar.UseVisualStyleBackColor = false;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // SEQVENDA
            // 
            this.SEQVENDA.DataPropertyName = "SEQVENDA";
            this.SEQVENDA.HeaderText = "Seq";
            this.SEQVENDA.MinimumWidth = 50;
            this.SEQVENDA.Name = "SEQVENDA";
            this.SEQVENDA.ReadOnly = true;
            this.SEQVENDA.Width = 50;
            // 
            // DTAVENDA
            // 
            this.DTAVENDA.DataPropertyName = "DTAVENDA";
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.DTAVENDA.DefaultCellStyle = dataGridViewCellStyle13;
            this.DTAVENDA.HeaderText = "Data";
            this.DTAVENDA.MinimumWidth = 80;
            this.DTAVENDA.Name = "DTAVENDA";
            this.DTAVENDA.ReadOnly = true;
            this.DTAVENDA.Width = 80;
            // 
            // NOMERAZAO
            // 
            this.NOMERAZAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMERAZAO.DataPropertyName = "NOMERAZAO";
            this.NOMERAZAO.HeaderText = "Cliente";
            this.NOMERAZAO.Name = "NOMERAZAO";
            this.NOMERAZAO.ReadOnly = true;
            // 
            // QTDEITENS
            // 
            this.QTDEITENS.DataPropertyName = "QTDEITENS";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.QTDEITENS.DefaultCellStyle = dataGridViewCellStyle14;
            this.QTDEITENS.HeaderText = "Itens";
            this.QTDEITENS.MinimumWidth = 50;
            this.QTDEITENS.Name = "QTDEITENS";
            this.QTDEITENS.ReadOnly = true;
            this.QTDEITENS.Width = 50;
            // 
            // VLRTOTAL
            // 
            this.VLRTOTAL.DataPropertyName = "VLRTOTAL";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.VLRTOTAL.DefaultCellStyle = dataGridViewCellStyle15;
            this.VLRTOTAL.HeaderText = "Vlr Total";
            this.VLRTOTAL.Name = "VLRTOTAL";
            this.VLRTOTAL.ReadOnly = true;
            // 
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(675, 484);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(473, 408);
            this.Name = "frmConsultaVenda";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Text = "Consulta de Vendas";
            this.Load += new System.EventHandler(this.frmConsultaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQVENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTAVENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMERAZAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDEITENS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLRTOTAL;
    }
}