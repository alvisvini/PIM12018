namespace teste
{
    partial class frmCadastroProduto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            this.ab3 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.categoria = new MetroFramework.Controls.MetroComboBox();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tbSeq = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbObs = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbPreco = new System.Windows.Forms.NumericUpDown();
            this.Salvar = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbMarca = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbDescricao = new MetroFramework.Controls.MetroTextBox();
            this.ribbonUpDown1 = new System.Windows.Forms.RibbonUpDown();
            this.ab3.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ab3
            // 
            this.ab3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ab3.Controls.Add(this.metroTabPage1);
            this.ab3.Location = new System.Drawing.Point(11, 63);
            this.ab3.Name = "ab3";
            this.ab3.SelectedIndex = 0;
            this.ab3.Size = new System.Drawing.Size(805, 416);
            this.ab3.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.categoria);
            this.metroTabPage1.Controls.Add(this.Pesquisar);
            this.metroTabPage1.Controls.Add(this.Limpar);
            this.metroTabPage1.Controls.Add(this.Excluir);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.tbSeq);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.tbObs);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.tbPreco);
            this.metroTabPage1.Controls.Add(this.Salvar);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.numericUpDown1);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.tbMarca);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.pictureBox1);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.tbDescricao);
            this.metroTabPage1.CustomBackground = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(797, 377);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Dados Gerais";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "R$";
            // 
            // categoria
            // 
            this.categoria.DisplayMember = "DESCRICAO";
            this.categoria.FormattingEnabled = true;
            this.categoria.ItemHeight = 23;
            this.categoria.Location = new System.Drawing.Point(99, 159);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(395, 29);
            this.categoria.TabIndex = 24;
            // 
            // Pesquisar
            // 
            this.Pesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pesquisar.FlatAppearance.BorderSize = 0;
            this.Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pesquisar.Image = global::MiniPack.Properties.Resources.icons8_search_24;
            this.Pesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pesquisar.Location = new System.Drawing.Point(360, 308);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(81, 46);
            this.Pesquisar.TabIndex = 23;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Pesquisar.UseVisualStyleBackColor = false;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Limpar.FlatAppearance.BorderSize = 0;
            this.Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpar.Image = global::MiniPack.Properties.Resources.icons8_clear_formatting_24;
            this.Limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Limpar.Location = new System.Drawing.Point(99, 308);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(81, 46);
            this.Limpar.TabIndex = 22;
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
            this.Excluir.Location = new System.Drawing.Point(273, 308);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(81, 46);
            this.Excluir.TabIndex = 21;
            this.Excluir.Text = "Excluir";
            this.Excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.Location = new System.Drawing.Point(12, 40);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(31, 19);
            this.metroLabel8.TabIndex = 20;
            this.metroLabel8.Text = "Seq";
            // 
            // tbSeq
            // 
            this.tbSeq.BackColor = System.Drawing.Color.White;
            this.tbSeq.CustomBackground = true;
            this.tbSeq.Location = new System.Drawing.Point(99, 40);
            this.tbSeq.Name = "tbSeq";
            this.tbSeq.Size = new System.Drawing.Size(81, 23);
            this.tbSeq.TabIndex = 19;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.Location = new System.Drawing.Point(12, 164);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(67, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Categoria";
            // 
            // tbObs
            // 
            this.tbObs.BackColor = System.Drawing.Color.White;
            this.tbObs.CustomBackground = true;
            this.tbObs.Location = new System.Drawing.Point(99, 203);
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(395, 23);
            this.tbObs.TabIndex = 17;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 245);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(78, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Numeracao";
            // 
            // tbPreco
            // 
            this.tbPreco.DecimalPlaces = 2;
            this.tbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreco.Location = new System.Drawing.Point(396, 248);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(81, 22);
            this.tbPreco.TabIndex = 15;
            this.tbPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Salvar.FlatAppearance.BorderSize = 0;
            this.Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salvar.Image = global::MiniPack.Properties.Resources.icons8_mais_24;
            this.Salvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Salvar.Location = new System.Drawing.Point(186, 308);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(81, 46);
            this.Salvar.TabIndex = 14;
            this.Salvar.Text = "Salvar";
            this.Salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Location = new System.Drawing.Point(579, 30);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(116, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Imagem Ilustrativa";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(99, 245);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 22);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.Location = new System.Drawing.Point(290, 248);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Preço Unit.";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 207);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Observacao";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Marca";
            // 
            // tbMarca
            // 
            this.tbMarca.BackColor = System.Drawing.Color.White;
            this.tbMarca.CustomBackground = true;
            this.tbMarca.Location = new System.Drawing.Point(99, 122);
            this.tbMarca.MaxLength = 250;
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(395, 23);
            this.tbMarca.TabIndex = 6;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(521, 282);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(126, 31);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Carregar Imagem";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Location = new System.Drawing.Point(521, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Descrição";
            // 
            // tbDescricao
            // 
            this.tbDescricao.BackColor = System.Drawing.Color.White;
            this.tbDescricao.CustomBackground = true;
            this.tbDescricao.Location = new System.Drawing.Point(99, 82);
            this.tbDescricao.MaxLength = 250;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(395, 23);
            this.tbDescricao.TabIndex = 2;
            // 
            // ribbonUpDown1
            // 
            this.ribbonUpDown1.TextBoxText = "";
            this.ribbonUpDown1.TextBoxWidth = 50;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(839, 537);
            this.Controls.Add(this.ab3);
            this.MinimumSize = new System.Drawing.Size(473, 408);
            this.Name = "frmCadastroProduto";
            this.Resizable = false;
            this.Text = "Cadastro De Produtos";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.ab3.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl ab3;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbDescricao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbMarca;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.RibbonUpDown ribbonUpDown1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.NumericUpDown tbPreco;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbObs;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox tbSeq;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Pesquisar;
        private MetroFramework.Controls.MetroComboBox categoria;
        private System.Windows.Forms.Label label1;
    }
}

