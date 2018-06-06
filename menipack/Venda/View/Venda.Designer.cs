namespace MiniPack.Venda.View
{
    partial class Venda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbDescricao = new MetroFramework.Controls.MetroTextBox();
            this.tbCodigo = new MetroFramework.Controls.MetroTextBox();
            this.tbVlrUnit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbNomeRazao = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbQtdeEstq = new MetroFramework.Controls.MetroTextBox();
            this.tbSeq = new MetroFramework.Controls.MetroTextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.tbQtde = new System.Windows.Forms.NumericUpDown();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbSeqVenda = new MetroFramework.Controls.MetroTextBox();
            this.tblItens = new System.Windows.Forms.DataGridView();
            this.SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLRUNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOTALITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTotalVenda = new MetroFramework.Controls.MetroTextBox();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.tbSeqCliente = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDescricao
            // 
            this.tbDescricao.BackColor = System.Drawing.Color.White;
            this.tbDescricao.Location = new System.Drawing.Point(180, 83);
            this.tbDescricao.MaxLength = 250;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.ReadOnly = true;
            this.tbDescricao.Size = new System.Drawing.Size(417, 23);
            this.tbDescricao.TabIndex = 4;
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.Color.White;
            this.tbCodigo.CustomBackground = true;
            this.tbCodigo.Location = new System.Drawing.Point(15, 83);
            this.tbCodigo.MaxLength = 15;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(130, 23);
            this.tbCodigo.TabIndex = 5;
            this.tbCodigo.UseStyleColors = true;
            this.tbCodigo.Validated += new System.EventHandler(this.tbCodigo_Validated);
            // 
            // tbVlrUnit
            // 
            this.tbVlrUnit.BackColor = System.Drawing.Color.White;
            this.tbVlrUnit.Location = new System.Drawing.Point(148, 128);
            this.tbVlrUnit.MaxLength = 10;
            this.tbVlrUnit.Name = "tbVlrUnit";
            this.tbVlrUnit.ReadOnly = true;
            this.tbVlrUnit.Size = new System.Drawing.Size(73, 23);
            this.tbVlrUnit.TabIndex = 6;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Código Produto";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(148, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Descricao";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(148, 109);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Vlr Unit";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(228, 109);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Qtde";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(522, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSeqCliente);
            this.groupBox1.Controls.Add(this.tbCpf);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.tbNomeRazao);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbQtdeEstq);
            this.groupBox1.Controls.Add(this.tbSeq);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnBuscarProduto);
            this.groupBox1.Controls.Add(this.tbQtde);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tbVlrUnit);
            this.groupBox1.Controls.Add(this.tbCodigo);
            this.groupBox1.Controls.Add(this.tbDescricao);
            this.groupBox1.Location = new System.Drawing.Point(32, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 169);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // tbCpf
            // 
            this.tbCpf.Culture = new System.Globalization.CultureInfo("en-US");
            this.tbCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCpf.Location = new System.Drawing.Point(16, 35);
            this.tbCpf.Mask = "000.000.000-00";
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(127, 22);
            this.tbCpf.TabIndex = 40;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::MiniPack.Properties.Resources.icons8_pesquisar_16;
            this.btnBuscarCliente.Location = new System.Drawing.Point(149, 35);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarCliente.TabIndex = 39;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(148, 13);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(86, 19);
            this.metroLabel6.TabIndex = 38;
            this.metroLabel6.Text = "Nome Razao";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(15, 13);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(77, 19);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "CPF Cliente";
            // 
            // tbNomeRazao
            // 
            this.tbNomeRazao.BackColor = System.Drawing.Color.White;
            this.tbNomeRazao.Location = new System.Drawing.Point(180, 35);
            this.tbNomeRazao.MaxLength = 250;
            this.tbNomeRazao.Name = "tbNomeRazao";
            this.tbNomeRazao.ReadOnly = true;
            this.tbNomeRazao.Size = new System.Drawing.Size(417, 23);
            this.tbNomeRazao.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MiniPack.Properties.Resources.icons8_mais_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(16, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 47);
            this.button1.TabIndex = 34;
            this.button1.Text = "Consultar Produtos";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbQtdeEstq
            // 
            this.tbQtdeEstq.BackColor = System.Drawing.Color.White;
            this.tbQtdeEstq.Location = new System.Drawing.Point(322, 127);
            this.tbQtdeEstq.MaxLength = 10;
            this.tbQtdeEstq.Name = "tbQtdeEstq";
            this.tbQtdeEstq.ReadOnly = true;
            this.tbQtdeEstq.Size = new System.Drawing.Size(18, 23);
            this.tbQtdeEstq.TabIndex = 17;
            this.tbQtdeEstq.Visible = false;
            // 
            // tbSeq
            // 
            this.tbSeq.BackColor = System.Drawing.Color.White;
            this.tbSeq.Location = new System.Drawing.Point(298, 128);
            this.tbSeq.MaxLength = 10;
            this.tbSeq.Name = "tbSeq";
            this.tbSeq.ReadOnly = true;
            this.tbSeq.Size = new System.Drawing.Size(18, 23);
            this.tbSeq.TabIndex = 16;
            this.tbSeq.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(441, 128);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Image = global::MiniPack.Properties.Resources.icons8_pesquisar_16;
            this.btnBuscarProduto.Location = new System.Drawing.Point(149, 83);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarProduto.TabIndex = 14;
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // tbQtde
            // 
            this.tbQtde.DecimalPlaces = 2;
            this.tbQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQtde.Location = new System.Drawing.Point(228, 128);
            this.tbQtde.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tbQtde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbQtde.Name = "tbQtde";
            this.tbQtde.Size = new System.Drawing.Size(64, 22);
            this.tbQtde.TabIndex = 13;
            this.tbQtde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(597, 12);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Seq";
            // 
            // tbSeqVenda
            // 
            this.tbSeqVenda.BackColor = System.Drawing.Color.White;
            this.tbSeqVenda.CustomBackground = true;
            this.tbSeqVenda.Location = new System.Drawing.Point(597, 34);
            this.tbSeqVenda.MaxLength = 15;
            this.tbSeqVenda.Name = "tbSeqVenda";
            this.tbSeqVenda.Size = new System.Drawing.Size(66, 23);
            this.tbSeqVenda.TabIndex = 35;
            this.tbSeqVenda.UseStyleColors = true;
            this.tbSeqVenda.Click += new System.EventHandler(this.tbSeqVenda_Click);
            // 
            // tblItens
            // 
            this.tblItens.AllowUserToAddRows = false;
            this.tblItens.AllowUserToDeleteRows = false;
            this.tblItens.AllowUserToResizeColumns = false;
            this.tblItens.AllowUserToResizeRows = false;
            this.tblItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEQ,
            this.CODIGO,
            this.DESCRICAO,
            this.QTDE,
            this.VLRUNITARIO,
            this.SUBTOTALITEM});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblItens.DefaultCellStyle = dataGridViewCellStyle1;
            this.tblItens.EnableHeadersVisualStyles = false;
            this.tblItens.Location = new System.Drawing.Point(32, 238);
            this.tblItens.MultiSelect = false;
            this.tblItens.Name = "tblItens";
            this.tblItens.ReadOnly = true;
            this.tblItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblItens.Size = new System.Drawing.Size(637, 248);
            this.tblItens.TabIndex = 32;
            // 
            // SEQ
            // 
            this.SEQ.DataPropertyName = "SEQ";
            this.SEQ.HeaderText = "SEQ";
            this.SEQ.Name = "SEQ";
            this.SEQ.ReadOnly = true;
            this.SEQ.Visible = false;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.MinimumWidth = 80;
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 80;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            // 
            // QTDE
            // 
            this.QTDE.DataPropertyName = "QTDE";
            this.QTDE.HeaderText = "QTDE";
            this.QTDE.Name = "QTDE";
            this.QTDE.ReadOnly = true;
            // 
            // VLRUNITARIO
            // 
            this.VLRUNITARIO.DataPropertyName = "VLRUNITARIO";
            this.VLRUNITARIO.HeaderText = "VLR UNIT";
            this.VLRUNITARIO.Name = "VLRUNITARIO";
            this.VLRUNITARIO.ReadOnly = true;
            // 
            // SUBTOTALITEM
            // 
            this.SUBTOTALITEM.DataPropertyName = "SUBTOTALITEM";
            this.SUBTOTALITEM.HeaderText = "TOTAL ITEM";
            this.SUBTOTALITEM.Name = "SUBTOTALITEM";
            this.SUBTOTALITEM.ReadOnly = true;
            // 
            // tbTotalVenda
            // 
            this.tbTotalVenda.BackColor = System.Drawing.Color.Blue;
            this.tbTotalVenda.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbTotalVenda.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbTotalVenda.ForeColor = System.Drawing.Color.Red;
            this.tbTotalVenda.Location = new System.Drawing.Point(32, 492);
            this.tbTotalVenda.MaxLength = 10;
            this.tbTotalVenda.Name = "tbTotalVenda";
            this.tbTotalVenda.ReadOnly = true;
            this.tbTotalVenda.Size = new System.Drawing.Size(637, 30);
            this.tbTotalVenda.TabIndex = 15;
            this.tbTotalVenda.Text = "0.00";
            this.tbTotalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pbImagem
            // 
            this.pbImagem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pbImagem.BackgroundImage = global::MiniPack.Properties.Resources.unavailable;
            this.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pbImagem.Location = new System.Drawing.Point(675, 87);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(211, 203);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagem.TabIndex = 33;
            this.pbImagem.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = global::MiniPack.Properties.Resources.icons8_clear_formatting_24;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(675, 334);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 55);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::MiniPack.Properties.Resources.icons8_mais_24;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(675, 395);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 55);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "Finalizar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Pesquisar
            // 
            this.Pesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pesquisar.FlatAppearance.BorderSize = 0;
            this.Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pesquisar.Image = global::MiniPack.Properties.Resources.icons8_search_24;
            this.Pesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pesquisar.Location = new System.Drawing.Point(805, 334);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(81, 55);
            this.Pesquisar.TabIndex = 34;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Pesquisar.UseVisualStyleBackColor = false;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // tbSeqCliente
            // 
            this.tbSeqCliente.BackColor = System.Drawing.Color.White;
            this.tbSeqCliente.Location = new System.Drawing.Point(346, 127);
            this.tbSeqCliente.MaxLength = 10;
            this.tbSeqCliente.Name = "tbSeqCliente";
            this.tbSeqCliente.ReadOnly = true;
            this.tbSeqCliente.Size = new System.Drawing.Size(18, 23);
            this.tbSeqCliente.TabIndex = 41;
            this.tbSeqCliente.Visible = false;
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(909, 555);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.tbSeqVenda);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.tbTotalVenda);
            this.Controls.Add(this.tblItens);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Venda";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbDescricao;
        private MetroFramework.Controls.MetroTextBox tbCodigo;
        private MetroFramework.Controls.MetroTextBox tbVlrUnit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown tbQtde;
        private System.Windows.Forms.DataGridView tblItens;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnBuscarProduto;
        private MetroFramework.Controls.MetroTextBox tbTotalVenda;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox pbImagem;
        private MetroFramework.Controls.MetroTextBox tbSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLRUNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTALITEM;
        private MetroFramework.Controls.MetroTextBox tbQtdeEstq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Pesquisar;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbSeqVenda;
        private System.Windows.Forms.Button btnBuscarCliente;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbNomeRazao;
        private System.Windows.Forms.MaskedTextBox tbCpf;
        private MetroFramework.Controls.MetroTextBox tbSeqCliente;
    }
}