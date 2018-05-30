using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using MetroFramework;
using MetroFramework.Forms;

namespace teste
{
    partial class frmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            this.ab3 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tbnasc = new System.Windows.Forms.MaskedTextBox();
            this.tbrecado = new System.Windows.Forms.MaskedTextBox();
            this.TBtelfixo = new System.Windows.Forms.MaskedTextBox();
            this.tbcel = new System.Windows.Forms.MaskedTextBox();
            this.tbcpf = new System.Windows.Forms.MaskedTextBox();
            this.cbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.cmbEstCivil = new System.Windows.Forms.ComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tbEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbRg = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tbSeq = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbNomeRazao = new MetroFramework.Controls.MetroLabel();
            this.tbDescricao = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.tbSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tbID = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNro = new System.Windows.Forms.MaskedTextBox();
            this.tbCep = new System.Windows.Forms.MaskedTextBox();
            this.tbPais = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.tbUf = new MetroFramework.Controls.MetroTextBox();
            this.tbCidade = new MetroFramework.Controls.MetroTextBox();
            this.tbComplemento = new MetroFramework.Controls.MetroTextBox();
            this.tbBairro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel28 = new MetroFramework.Controls.MetroLabel();
            this.tbLogradouro = new MetroFramework.Controls.MetroTextBox();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.ribbonUpDown1 = new System.Windows.Forms.RibbonUpDown();
            this.ab3.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ab3
            // 
            this.ab3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ab3.Controls.Add(this.metroTabPage1);
            this.ab3.Controls.Add(this.metroTabPage3);
            this.ab3.Controls.Add(this.metroTabPage2);
            this.ab3.Location = new System.Drawing.Point(11, 63);
            this.ab3.Name = "ab3";
            this.ab3.SelectedIndex = 2;
            this.ab3.Size = new System.Drawing.Size(802, 359);
            this.ab3.TabIndex = 4;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroTabPage1.Controls.Add(this.tbnasc);
            this.metroTabPage1.Controls.Add(this.tbrecado);
            this.metroTabPage1.Controls.Add(this.TBtelfixo);
            this.metroTabPage1.Controls.Add(this.tbcel);
            this.metroTabPage1.Controls.Add(this.tbcpf);
            this.metroTabPage1.Controls.Add(this.cbTipoPessoa);
            this.metroTabPage1.Controls.Add(this.metroLabel12);
            this.metroTabPage1.Controls.Add(this.cmbEstCivil);
            this.metroTabPage1.Controls.Add(this.metroLabel11);
            this.metroTabPage1.Controls.Add(this.cmbSexo);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.tbEmail);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.tbRg);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.tbSeq);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.pictureBox1);
            this.metroTabPage1.Controls.Add(this.tbNomeRazao);
            this.metroTabPage1.Controls.Add(this.tbDescricao);
            this.metroTabPage1.CustomBackground = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(794, 320);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Dados Gerais";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // tbnasc
            // 
            this.tbnasc.Location = new System.Drawing.Point(100, 199);
            this.tbnasc.Mask = "00/00/0000";
            this.tbnasc.Name = "tbnasc";
            this.tbnasc.Size = new System.Drawing.Size(80, 20);
            this.tbnasc.TabIndex = 6;
            // 
            // tbrecado
            // 
            this.tbrecado.Location = new System.Drawing.Point(311, 201);
            this.tbrecado.Mask = "(00) 00000-0000";
            this.tbrecado.Name = "tbrecado";
            this.tbrecado.Size = new System.Drawing.Size(104, 20);
            this.tbrecado.TabIndex = 7;
            // 
            // TBtelfixo
            // 
            this.TBtelfixo.Location = new System.Drawing.Point(311, 162);
            this.TBtelfixo.Mask = "(00) 00000-0000";
            this.TBtelfixo.Name = "TBtelfixo";
            this.TBtelfixo.Size = new System.Drawing.Size(104, 20);
            this.TBtelfixo.TabIndex = 5;
            // 
            // tbcel
            // 
            this.tbcel.Location = new System.Drawing.Point(311, 125);
            this.tbcel.Mask = "(00) 00000-0000";
            this.tbcel.Name = "tbcel";
            this.tbcel.Size = new System.Drawing.Size(104, 20);
            this.tbcel.TabIndex = 3;
            // 
            // tbcpf
            // 
            this.tbcpf.Location = new System.Drawing.Point(99, 125);
            this.tbcpf.Mask = "000.000.000-00";
            this.tbcpf.Name = "tbcpf";
            this.tbcpf.Size = new System.Drawing.Size(104, 20);
            this.tbcpf.TabIndex = 2;
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.DisplayMember = "DESCRICAO";
            this.cbTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPessoa.FormattingEnabled = true;
            this.cbTipoPessoa.ItemHeight = 13;
            this.cbTipoPessoa.Items.AddRange(new object[] {
            "Cliente",
            "Funcionário"});
            this.cbTipoPessoa.Location = new System.Drawing.Point(310, 40);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Size = new System.Drawing.Size(157, 21);
            this.cbTipoPessoa.TabIndex = 0;
            this.cbTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.cbTipoPessoa_SelectedIndexChanged);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel12.CustomBackground = true;
            this.metroLabel12.Location = new System.Drawing.Point(230, 41);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(78, 19);
            this.metroLabel12.TabIndex = 42;
            this.metroLabel12.Text = "Tipo Pessoa";
            // 
            // cmbEstCivil
            // 
            this.cmbEstCivil.DisplayMember = "DESCRICAO";
            this.cmbEstCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstCivil.FormattingEnabled = true;
            this.cmbEstCivil.ItemHeight = 13;
            this.cmbEstCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado",
            "Outros"});
            this.cmbEstCivil.Location = new System.Drawing.Point(310, 240);
            this.cmbEstCivil.Name = "cmbEstCivil";
            this.cmbEstCivil.Size = new System.Drawing.Size(157, 21);
            this.cmbEstCivil.TabIndex = 9;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel11.CustomBackground = true;
            this.metroLabel11.Location = new System.Drawing.Point(229, 242);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(76, 19);
            this.metroLabel11.TabIndex = 40;
            this.metroLabel11.Text = "Estado Civil";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DisplayMember = "DESCRICAO";
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.ItemHeight = 13;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Indefinido"});
            this.cmbSexo.Location = new System.Drawing.Point(99, 242);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(115, 21);
            this.cmbSexo.TabIndex = 8;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel10.CustomBackground = true;
            this.metroLabel10.Location = new System.Drawing.Point(23, 244);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(37, 19);
            this.metroLabel10.TabIndex = 38;
            this.metroLabel10.Text = "Sexo";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.CustomBackground = true;
            this.tbEmail.Location = new System.Drawing.Point(99, 279);
            this.tbEmail.MaxLength = 250;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(368, 23);
            this.tbEmail.TabIndex = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.Location = new System.Drawing.Point(23, 283);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(47, 19);
            this.metroLabel9.TabIndex = 36;
            this.metroLabel9.Text = "E-mail";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 129);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(33, 19);
            this.metroLabel7.TabIndex = 35;
            this.metroLabel7.Text = "CPF";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 162);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(26, 19);
            this.metroLabel6.TabIndex = 34;
            this.metroLabel6.Text = "RG";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 200);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Data Nasc.";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.Location = new System.Drawing.Point(232, 129);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Tel. Celular";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(232, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Tel. Fixo";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(232, 202);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Tel. Recado";
            // 
            // tbRg
            // 
            this.tbRg.BackColor = System.Drawing.Color.White;
            this.tbRg.CustomBackground = true;
            this.tbRg.Location = new System.Drawing.Point(99, 158);
            this.tbRg.MaxLength = 250;
            this.tbRg.Name = "tbRg";
            this.tbRg.Size = new System.Drawing.Size(104, 23);
            this.tbRg.TabIndex = 4;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 40);
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
            // tbNomeRazao
            // 
            this.tbNomeRazao.AutoSize = true;
            this.tbNomeRazao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbNomeRazao.CustomBackground = true;
            this.tbNomeRazao.Location = new System.Drawing.Point(23, 82);
            this.tbNomeRazao.Name = "tbNomeRazao";
            this.tbNomeRazao.Size = new System.Drawing.Size(46, 19);
            this.tbNomeRazao.TabIndex = 3;
            this.tbNomeRazao.Text = "Nome";
            // 
            // tbDescricao
            // 
            this.tbDescricao.BackColor = System.Drawing.Color.White;
            this.tbDescricao.CustomBackground = true;
            this.tbDescricao.Location = new System.Drawing.Point(99, 82);
            this.tbDescricao.MaxLength = 250;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(368, 23);
            this.tbDescricao.TabIndex = 1;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroTabPage3.Controls.Add(this.metroLabel14);
            this.metroTabPage3.Controls.Add(this.tbSenha);
            this.metroTabPage3.Controls.Add(this.metroLabel13);
            this.metroTabPage3.Controls.Add(this.tbID);
            this.metroTabPage3.CustomBackground = true;
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(794, 320);
            this.metroTabPage3.TabIndex = 3;
            this.metroTabPage3.Text = "Acesso";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel14.CustomBackground = true;
            this.metroLabel14.Location = new System.Drawing.Point(109, 93);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(44, 19);
            this.metroLabel14.TabIndex = 7;
            this.metroLabel14.Text = "Senha";
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.Color.White;
            this.tbSenha.CustomBackground = true;
            this.tbSenha.Location = new System.Drawing.Point(185, 93);
            this.tbSenha.MaxLength = 15;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(148, 23);
            this.tbSenha.TabIndex = 6;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel13.CustomBackground = true;
            this.metroLabel13.Location = new System.Drawing.Point(109, 64);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(21, 19);
            this.metroLabel13.TabIndex = 5;
            this.metroLabel13.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.White;
            this.tbID.CustomBackground = true;
            this.tbID.Location = new System.Drawing.Point(185, 64);
            this.tbID.MaxLength = 15;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(148, 23);
            this.tbID.TabIndex = 4;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroTabPage2.Controls.Add(this.button1);
            this.metroTabPage2.Controls.Add(this.tbNro);
            this.metroTabPage2.Controls.Add(this.tbCep);
            this.metroTabPage2.Controls.Add(this.tbPais);
            this.metroTabPage2.Controls.Add(this.metroLabel19);
            this.metroTabPage2.Controls.Add(this.metroLabel20);
            this.metroTabPage2.Controls.Add(this.metroLabel21);
            this.metroTabPage2.Controls.Add(this.metroLabel22);
            this.metroTabPage2.Controls.Add(this.metroLabel23);
            this.metroTabPage2.Controls.Add(this.metroLabel25);
            this.metroTabPage2.Controls.Add(this.tbUf);
            this.metroTabPage2.Controls.Add(this.tbCidade);
            this.metroTabPage2.Controls.Add(this.tbComplemento);
            this.metroTabPage2.Controls.Add(this.tbBairro);
            this.metroTabPage2.Controls.Add(this.metroLabel26);
            this.metroTabPage2.Controls.Add(this.metroLabel28);
            this.metroTabPage2.Controls.Add(this.tbLogradouro);
            this.metroTabPage2.CustomBackground = true;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(794, 320);
            this.metroTabPage2.TabIndex = 2;
            this.metroTabPage2.Text = "Endereco";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MiniPack.Properties.Resources.icons8_search_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(204, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 26);
            this.button1.TabIndex = 24;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNro
            // 
            this.tbNro.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNro.Location = new System.Drawing.Point(523, 82);
            this.tbNro.Mask = "00000";
            this.tbNro.Name = "tbNro";
            this.tbNro.Size = new System.Drawing.Size(66, 22);
            this.tbNro.TabIndex = 1;
            // 
            // tbCep
            // 
            this.tbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCep.Location = new System.Drawing.Point(99, 44);
            this.tbCep.Mask = "00000-999";
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(100, 22);
            this.tbCep.TabIndex = 0;
            // 
            // tbPais
            // 
            this.tbPais.BackColor = System.Drawing.Color.White;
            this.tbPais.CustomBackground = true;
            this.tbPais.Location = new System.Drawing.Point(99, 233);
            this.tbPais.MaxLength = 250;
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(368, 23);
            this.tbPais.TabIndex = 3;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel19.CustomBackground = true;
            this.metroLabel19.Location = new System.Drawing.Point(62, 237);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(31, 19);
            this.metroLabel19.TabIndex = 36;
            this.metroLabel19.Text = "Pais";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel20.CustomBackground = true;
            this.metroLabel20.Location = new System.Drawing.Point(48, 119);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(45, 19);
            this.metroLabel20.TabIndex = 35;
            this.metroLabel20.Text = "Bairro";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel21.CustomBackground = true;
            this.metroLabel21.Location = new System.Drawing.Point(2, 158);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(91, 19);
            this.metroLabel21.TabIndex = 34;
            this.metroLabel21.Text = "Compemento";
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel22.CustomBackground = true;
            this.metroLabel22.Location = new System.Drawing.Point(42, 202);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(51, 19);
            this.metroLabel22.TabIndex = 33;
            this.metroLabel22.Text = "Cidade";
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel23.CustomBackground = true;
            this.metroLabel23.Location = new System.Drawing.Point(485, 84);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(32, 19);
            this.metroLabel23.TabIndex = 32;
            this.metroLabel23.Text = "Nro";
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel25.CustomBackground = true;
            this.metroLabel25.Location = new System.Drawing.Point(382, 202);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(25, 19);
            this.metroLabel25.TabIndex = 30;
            this.metroLabel25.Text = "UF";
            // 
            // tbUf
            // 
            this.tbUf.BackColor = System.Drawing.Color.White;
            this.tbUf.CustomBackground = true;
            this.tbUf.Location = new System.Drawing.Point(413, 198);
            this.tbUf.MaxLength = 2;
            this.tbUf.Name = "tbUf";
            this.tbUf.Size = new System.Drawing.Size(54, 23);
            this.tbUf.TabIndex = 29;
            // 
            // tbCidade
            // 
            this.tbCidade.BackColor = System.Drawing.Color.White;
            this.tbCidade.CustomBackground = true;
            this.tbCidade.Location = new System.Drawing.Point(99, 198);
            this.tbCidade.MaxLength = 250;
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(271, 23);
            this.tbCidade.TabIndex = 28;
            // 
            // tbComplemento
            // 
            this.tbComplemento.BackColor = System.Drawing.Color.White;
            this.tbComplemento.CustomBackground = true;
            this.tbComplemento.Location = new System.Drawing.Point(99, 158);
            this.tbComplemento.MaxLength = 250;
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(368, 23);
            this.tbComplemento.TabIndex = 2;
            // 
            // tbBairro
            // 
            this.tbBairro.BackColor = System.Drawing.Color.White;
            this.tbBairro.CustomBackground = true;
            this.tbBairro.Location = new System.Drawing.Point(99, 119);
            this.tbBairro.MaxLength = 250;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(368, 23);
            this.tbBairro.TabIndex = 24;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel26.CustomBackground = true;
            this.metroLabel26.Location = new System.Drawing.Point(60, 44);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(33, 19);
            this.metroLabel26.TabIndex = 20;
            this.metroLabel26.Text = "CEP";
            // 
            // metroLabel28
            // 
            this.metroLabel28.AutoSize = true;
            this.metroLabel28.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel28.CustomBackground = true;
            this.metroLabel28.Location = new System.Drawing.Point(14, 82);
            this.metroLabel28.Name = "metroLabel28";
            this.metroLabel28.Size = new System.Drawing.Size(79, 19);
            this.metroLabel28.TabIndex = 3;
            this.metroLabel28.Text = "Logradouro";
            // 
            // tbLogradouro
            // 
            this.tbLogradouro.BackColor = System.Drawing.Color.White;
            this.tbLogradouro.CustomBackground = true;
            this.tbLogradouro.Location = new System.Drawing.Point(99, 82);
            this.tbLogradouro.MaxLength = 250;
            this.tbLogradouro.Name = "tbLogradouro";
            this.tbLogradouro.Size = new System.Drawing.Size(368, 23);
            this.tbLogradouro.TabIndex = 2;
            // 
            // Pesquisar
            // 
            this.Pesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pesquisar.FlatAppearance.BorderSize = 0;
            this.Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pesquisar.Image = global::MiniPack.Properties.Resources.icons8_search_24;
            this.Pesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pesquisar.Location = new System.Drawing.Point(401, 456);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(81, 46);
            this.Pesquisar.TabIndex = 3;
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
            this.Limpar.Location = new System.Drawing.Point(140, 456);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(81, 46);
            this.Limpar.TabIndex = 1;
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
            this.Excluir.Location = new System.Drawing.Point(314, 456);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(81, 46);
            this.Excluir.TabIndex = 2;
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
            this.Salvar.Location = new System.Drawing.Point(227, 456);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(81, 46);
            this.Salvar.TabIndex = 0;
            this.Salvar.Text = "Salvar";
            this.Salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // ribbonUpDown1
            // 
            this.ribbonUpDown1.TextBoxText = "";
            this.ribbonUpDown1.TextBoxWidth = 50;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(836, 527);
            this.Controls.Add(this.ab3);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Limpar);
            this.MinimumSize = new System.Drawing.Size(473, 408);
            this.Name = "frmCadastroCliente";
            this.Resizable = false;
            this.Text = "Cadastro De Pessoas";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.ab3.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override object InitializeLifetimeService()
        {
            return base.InitializeLifetimeService();
        }

        public override ObjRef CreateObjRef(Type requestedType)
        {
            return base.CreateObjRef(requestedType);
        }

        protected override object GetService(Type service)
        {
            return base.GetService(service);
        }

        protected override AccessibleObject GetAccessibilityObjectById(int objectId)
        {
            return base.GetAccessibilityObjectById(objectId);
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            return base.GetPreferredSize(proposedSize);
        }

        protected override AccessibleObject CreateAccessibilityInstance()
        {
            return base.CreateAccessibilityInstance();
        }

        protected override void DestroyHandle()
        {
            base.DestroyHandle();
        }

        protected override void InitLayout()
        {
            base.InitLayout();
        }

        protected override bool IsInputChar(char charCode)
        {
            return base.IsInputChar(charCode);
        }

        protected override bool IsInputKey(Keys keyData)
        {
            return base.IsInputKey(keyData);
        }

        protected override void NotifyInvalidate(Rectangle invalidatedArea)
        {
            base.NotifyInvalidate(invalidatedArea);
        }

        protected override void OnAutoSizeChanged(EventArgs e)
        {
            base.OnAutoSizeChanged(e);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
        }

        protected override void OnBindingContextChanged(EventArgs e)
        {
            base.OnBindingContextChanged(e);
        }

        protected override void OnCausesValidationChanged(EventArgs e)
        {
            base.OnCausesValidationChanged(e);
        }

        protected override void OnContextMenuChanged(EventArgs e)
        {
            base.OnContextMenuChanged(e);
        }

        protected override void OnContextMenuStripChanged(EventArgs e)
        {
            base.OnContextMenuStripChanged(e);
        }

        protected override void OnCursorChanged(EventArgs e)
        {
            base.OnCursorChanged(e);
        }

        protected override void OnDockChanged(EventArgs e)
        {
            base.OnDockChanged(e);
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
        }

        protected override void OnNotifyMessage(Message m)
        {
            base.OnNotifyMessage(m);
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
        }

        protected override void OnParentBackgroundImageChanged(EventArgs e)
        {
            base.OnParentBackgroundImageChanged(e);
        }

        protected override void OnParentBindingContextChanged(EventArgs e)
        {
            base.OnParentBindingContextChanged(e);
        }

        protected override void OnParentCursorChanged(EventArgs e)
        {
            base.OnParentCursorChanged(e);
        }

        protected override void OnParentEnabledChanged(EventArgs e)
        {
            base.OnParentEnabledChanged(e);
        }

        protected override void OnParentFontChanged(EventArgs e)
        {
            base.OnParentFontChanged(e);
        }

        protected override void OnParentForeColorChanged(EventArgs e)
        {
            base.OnParentForeColorChanged(e);
        }

        protected override void OnParentRightToLeftChanged(EventArgs e)
        {
            base.OnParentRightToLeftChanged(e);
        }

        protected override void OnParentVisibleChanged(EventArgs e)
        {
            base.OnParentVisibleChanged(e);
        }

        protected override void OnPrint(PaintEventArgs e)
        {
            base.OnPrint(e);
        }

        protected override void OnTabIndexChanged(EventArgs e)
        {
            base.OnTabIndexChanged(e);
        }

        protected override void OnTabStopChanged(EventArgs e)
        {
            base.OnTabStopChanged(e);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        protected override void OnClientSizeChanged(EventArgs e)
        {
            base.OnClientSizeChanged(e);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
        }

        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            base.OnDragEnter(drgevent);
        }

        protected override void OnDragOver(DragEventArgs drgevent)
        {
            base.OnDragOver(drgevent);
        }

        protected override void OnDragLeave(EventArgs e)
        {
            base.OnDragLeave(e);
        }

        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            base.OnDragDrop(drgevent);
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
        {
            base.OnGiveFeedback(gfbevent);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
        }

        protected override void OnHelpRequested(HelpEventArgs hevent)
        {
            base.OnHelpRequested(hevent);
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
        }

        protected override void OnMarginChanged(EventArgs e)
        {
            base.OnMarginChanged(e);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            base.OnMouseCaptureChanged(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
        }

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
        }

        protected override void OnQueryContinueDrag(QueryContinueDragEventArgs qcdevent)
        {
            base.OnQueryContinueDrag(qcdevent);
        }

        protected override void OnRegionChanged(EventArgs e)
        {
            base.OnRegionChanged(e);
        }

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            base.OnPreviewKeyDown(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        protected override void OnChangeUICues(UICuesEventArgs e)
        {
            base.OnChangeUICues(e);
        }

        protected override void OnSystemColorsChanged(EventArgs e)
        {
            base.OnSystemColorsChanged(e);
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
        }

        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
        }

        public override bool PreProcessMessage(ref Message msg)
        {
            return base.PreProcessMessage(ref msg);
        }

        protected override bool ProcessKeyEventArgs(ref Message m)
        {
            return base.ProcessKeyEventArgs(ref m);
        }

        protected override bool ProcessKeyMessage(ref Message m)
        {
            return base.ProcessKeyMessage(ref m);
        }

        public override void ResetBackColor()
        {
            base.ResetBackColor();
        }

        public override void ResetCursor()
        {
            base.ResetCursor();
        }

        public override void ResetFont()
        {
            base.ResetFont();
        }

        public override void ResetForeColor()
        {
            base.ResetForeColor();
        }

        public override void ResetRightToLeft()
        {
            base.ResetRightToLeft();
        }

        public override void Refresh()
        {
            base.Refresh();
        }

        public override void ResetText()
        {
            base.ResetText();
        }

        protected override Size SizeFromClientSize(Size clientSize)
        {
            return base.SizeFromClientSize(clientSize);
        }

        protected override void OnImeModeChanged(EventArgs e)
        {
            base.OnImeModeChanged(e);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
        }

        protected override void OnRightToLeftChanged(EventArgs e)
        {
            base.OnRightToLeftChanged(e);
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
        }

        protected override Point ScrollToControl(Control activeControl)
        {
            return base.ScrollToControl(activeControl);
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);
        }

        protected override void OnAutoValidateChanged(EventArgs e)
        {
            base.OnAutoValidateChanged(e);
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
        }

        protected override void AdjustFormScrollbars(bool displayScrollbars)
        {
            base.AdjustFormScrollbars(displayScrollbars);
        }

        protected override Control.ControlCollection CreateControlsInstance()
        {
            return base.CreateControlsInstance();
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();
        }

        protected override void DefWndProc(ref Message m)
        {
            base.DefWndProc(ref m);
        }

        protected override bool ProcessMnemonic(char charCode)
        {
            return base.ProcessMnemonic(charCode);
        }

        protected override void OnBackgroundImageChanged(EventArgs e)
        {
            base.OnBackgroundImageChanged(e);
        }

        protected override void OnBackgroundImageLayoutChanged(EventArgs e)
        {
            base.OnBackgroundImageLayoutChanged(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
        }

        protected override void OnHelpButtonClicked(CancelEventArgs e)
        {
            base.OnHelpButtonClicked(e);
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
        }

        protected override void OnMaximizedBoundsChanged(EventArgs e)
        {
            base.OnMaximizedBoundsChanged(e);
        }

        protected override void OnMaximumSizeChanged(EventArgs e)
        {
            base.OnMaximumSizeChanged(e);
        }

        protected override void OnMinimumSizeChanged(EventArgs e)
        {
            base.OnMinimumSizeChanged(e);
        }

        protected override void OnInputLanguageChanged(InputLanguageChangedEventArgs e)
        {
            base.OnInputLanguageChanged(e);
        }

        protected override void OnInputLanguageChanging(InputLanguageChangingEventArgs e)
        {
            base.OnInputLanguageChanging(e);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
        }

        protected override void OnMdiChildActivate(EventArgs e)
        {
            base.OnMdiChildActivate(e);
        }

        protected override void OnMenuStart(EventArgs e)
        {
            base.OnMenuStart(e);
        }

        protected override void OnMenuComplete(EventArgs e)
        {
            base.OnMenuComplete(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnRightToLeftLayoutChanged(EventArgs e)
        {
            base.OnRightToLeftLayoutChanged(e);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            return base.ProcessDialogKey(keyData);
        }

        protected override bool ProcessDialogChar(char charCode)
        {
            return base.ProcessDialogChar(charCode);
        }

        protected override bool ProcessKeyPreview(ref Message m)
        {
            return base.ProcessKeyPreview(ref m);
        }

        protected override bool ProcessTabKey(bool forward)
        {
            return base.ProcessTabKey(forward);
        }

        protected override void Select(bool directed, bool forward)
        {
            base.Select(directed, forward);
        }

        protected override void ScaleCore(float x, float y)
        {
            base.ScaleCore(x, y);
        }

        protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified)
        {
            return base.GetScaledBounds(bounds, factor, specified);
        }

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            base.ScaleControl(factor, specified);
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, height, specified);
        }

        protected override void SetClientSizeCore(int x, int y)
        {
            base.SetClientSizeCore(x, y);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override void UpdateDefaultButton()
        {
            base.UpdateDefaultButton();
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            base.OnResizeBegin(e);
        }

        protected override void OnStyleChanged(EventArgs e)
        {
            base.OnStyleChanged(e);
        }

        public override bool ValidateChildren()
        {
            return base.ValidateChildren();
        }

        public override bool ValidateChildren(ValidationConstraints validationConstraints)
        {
            return base.ValidateChildren(validationConstraints);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(value);
        }

        #endregion

        private MetroFramework.Controls.MetroTabControl ab3;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel tbNomeRazao;
        private MetroFramework.Controls.MetroTextBox tbDescricao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.RibbonUpDown ribbonUpDown1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox tbSeq;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Pesquisar;
        private MetroFramework.Controls.MetroTextBox tbEmail;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbRg;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox tbPais;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroTextBox tbUf;
        private MetroFramework.Controls.MetroTextBox tbCidade;
        private MetroFramework.Controls.MetroTextBox tbComplemento;
        private MetroFramework.Controls.MetroTextBox tbBairro;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroLabel metroLabel28;
        private MetroFramework.Controls.MetroTextBox tbLogradouro;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private ComboBox cmbSexo;
        private ComboBox cmbEstCivil;
        private ComboBox cbTipoPessoa;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MaskedTextBox tbNro;
        private MaskedTextBox tbCep;
        private MaskedTextBox tbcpf;
        private MaskedTextBox tbcel;
        private MaskedTextBox tbrecado;
        private MaskedTextBox TBtelfixo;
        private MaskedTextBox tbnasc;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox tbSenha;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox tbID;
        private Button button1;

        public override bool AllowDrop { get => base.AllowDrop; set => base.AllowDrop = value; }
        public override AnchorStyles Anchor { get => base.Anchor; set => base.Anchor = value; }
        public override Point AutoScrollOffset { get => base.AutoScrollOffset; set => base.AutoScrollOffset = value; }

        public override LayoutEngine LayoutEngine => base.LayoutEngine;

        public override Image BackgroundImage { get => base.BackgroundImage; set => base.BackgroundImage = value; }
        public override ImageLayout BackgroundImageLayout { get => base.BackgroundImageLayout; set => base.BackgroundImageLayout = value; }

        protected override bool CanRaiseEvents => base.CanRaiseEvents;

        public override ContextMenu ContextMenu { get => base.ContextMenu; set => base.ContextMenu = value; }
        public override ContextMenuStrip ContextMenuStrip { get => base.ContextMenuStrip; set => base.ContextMenuStrip = value; }
        public override Cursor Cursor { get => base.Cursor; set => base.Cursor = value; }

        protected override Cursor DefaultCursor => base.DefaultCursor;

        protected override Padding DefaultMargin => base.DefaultMargin;

        protected override Size DefaultMaximumSize => base.DefaultMaximumSize;

        protected override Size DefaultMinimumSize => base.DefaultMinimumSize;

        public override DockStyle Dock { get => base.Dock; set => base.Dock = value; }
        protected override bool DoubleBuffered { get => base.DoubleBuffered; set => base.DoubleBuffered = value; }

        public override bool Focused => base.Focused;

        public override Font Font { get => base.Font; set => base.Font = value; }
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }
        public override RightToLeft RightToLeft { get => base.RightToLeft; set => base.RightToLeft = value; }

        protected override bool ScaleChildren => base.ScaleChildren;

        protected override bool ShowKeyboardCues => base.ShowKeyboardCues;

        protected override bool ShowFocusCues => base.ShowFocusCues;

        protected override ImeMode ImeModeBase { get => base.ImeModeBase; set => base.ImeModeBase = value; }

        public override Rectangle DisplayRectangle => base.DisplayRectangle;

        public override BindingContext BindingContext { get => base.BindingContext; set => base.BindingContext = value; }

        protected override bool CanEnableIme => base.CanEnableIme;

        public override Size AutoScaleBaseSize { get => base.AutoScaleBaseSize; set => base.AutoScaleBaseSize = value; }
        public override bool AutoScroll { get => base.AutoScroll; set => base.AutoScroll = value; }
        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = value; }
        public override AutoValidate AutoValidate { get => base.AutoValidate; set => base.AutoValidate = value; }

        protected override ImeMode DefaultImeMode => base.DefaultImeMode;

        protected override Size DefaultSize => base.DefaultSize;

        public override Size MaximumSize { get => base.MaximumSize; set => base.MaximumSize = value; }
        public override Size MinimumSize { get => base.MinimumSize; set => base.MinimumSize = value; }
        public override bool RightToLeftLayout { get => base.RightToLeftLayout; set => base.RightToLeftLayout = value; }

        protected override bool ShowWithoutActivation => base.ShowWithoutActivation;

        public override string Text { get => base.Text; set => base.Text = value; }
        public override ISite Site { get => base.Site; set => base.Site = value; }

        public override Color BackColor => base.BackColor;

        protected override Padding DefaultPadding => base.DefaultPadding;

        protected override CreateParams CreateParams => base.CreateParams;
    }
}

