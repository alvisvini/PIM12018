using System;

namespace teste
{
    partial class MDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.ribbonHost1 = new System.Windows.Forms.RibbonHost();
            this.ribTabCadastro = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnCadProduto = new System.Windows.Forms.RibbonButton();
            this.btnCadCliente = new System.Windows.Forms.RibbonButton();
            this.btnCadCategoria = new System.Windows.Forms.RibbonButton();
            this.btnCadmarca = new System.Windows.Forms.RibbonButton();
            this.ribTabConsulta = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.btnConsCliente = new System.Windows.Forms.RibbonButton();
            this.btnConsProduto = new System.Windows.Forms.RibbonButton();
            this.ribTabVenda = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribTabJanela = new System.Windows.Forms.RibbonTab();
            this.ribTabSobre = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbonHost1
            // 
            this.ribbonHost1.HostedControl = null;
            // 
            // ribTabCadastro
            // 
            this.ribTabCadastro.Panels.Add(this.ribbonPanel1);
            this.ribTabCadastro.Text = "Cadastro";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreEnabled = false;
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.btnCadProduto);
            this.ribbonPanel1.Items.Add(this.btnCadCliente);
            this.ribbonPanel1.Items.Add(this.btnCadCategoria);
            this.ribbonPanel1.Items.Add(this.btnCadmarca);
            this.ribbonPanel1.Text = "";
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnCadProduto.Image")));
            this.btnCadProduto.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCadProduto.SmallImage")));
            this.btnCadProduto.Text = "Produto";
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadCliente.Image")));
            this.btnCadCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCadCliente.SmallImage")));
            this.btnCadCliente.Text = "Pessoas";
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnCadCategoria
            // 
            this.btnCadCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCadCategoria.Image")));
            this.btnCadCategoria.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCadCategoria.SmallImage")));
            this.btnCadCategoria.Text = "Categoria";
            this.btnCadCategoria.Click += new System.EventHandler(this.btnCAdCategoria);
            // 
            // btnCadmarca
            // 
            this.btnCadmarca.Image = global::MiniPack.Properties.Resources.icons8_mais_24;
            this.btnCadmarca.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCadmarca.SmallImage")));
            this.btnCadmarca.Text = "Marca";
            // 
            // ribTabConsulta
            // 
            this.ribTabConsulta.Panels.Add(this.ribbonPanel3);
            this.ribTabConsulta.Text = "Consulta";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.btnConsCliente);
            this.ribbonPanel3.Items.Add(this.btnConsProduto);
            this.ribbonPanel3.Text = "";
            // 
            // btnConsCliente
            // 
            this.btnConsCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnConsCliente.Image")));
            this.btnConsCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnConsCliente.SmallImage")));
            this.btnConsCliente.Text = "Cliente";
            this.btnConsCliente.Click += new System.EventHandler(this.btnConsCliente_Click);
            // 
            // btnConsProduto
            // 
            this.btnConsProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnConsProduto.Image")));
            this.btnConsProduto.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnConsProduto.SmallImage")));
            this.btnConsProduto.Text = "Produto";
            this.btnConsProduto.Click += new System.EventHandler(this.btnConsProduto_Click);
            // 
            // ribTabVenda
            // 
            this.ribTabVenda.Panels.Add(this.ribbonPanel4);
            this.ribTabVenda.Text = "Venda";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.ribbonButton2);
            this.ribbonPanel4.Items.Add(this.ribbonButton6);
            this.ribbonPanel4.Text = null;
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = global::MiniPack.Properties.Resources.icons8_sale_24;
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Venda";
            this.ribbonButton2.Click += new System.EventHandler(this.ribbonButton2_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            // 
            // ribbon1
            // 
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.OrbVisible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(720, 95);
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Tabs.Add(this.ribTabCadastro);
            this.ribbon1.Tabs.Add(this.ribTabConsulta);
            this.ribbon1.Tabs.Add(this.ribTabVenda);
            this.ribbon1.Tabs.Add(this.ribTabJanela);
            this.ribbon1.Tabs.Add(this.ribTabSobre);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribTabJanela
            // 
            this.ribTabJanela.Text = "Janela";
            // 
            // ribTabSobre
            // 
            this.ribTabSobre.Panels.Add(this.ribbonPanel2);
            this.ribTabSobre.Text = "Sobre";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Text = "ribbonPanel2";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.Image")));
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "Cadastro";
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.Image")));
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 442);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniPack - Loja de Artigos Esportivos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

       



        #endregion

        private System.Windows.Forms.RibbonHost ribbonHost1;
        private System.Windows.Forms.RibbonTab ribTabCadastro;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonTab ribTabConsulta;
        private System.Windows.Forms.RibbonTab ribTabVenda;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton btnCadProduto;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton btnCadCliente;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonButton btnCadCategoria;
        private System.Windows.Forms.RibbonTab ribTabJanela;
        private System.Windows.Forms.RibbonTab ribTabSobre;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton btnConsCliente;
        public System.Windows.Forms.RibbonButton btnConsProduto;
        private System.Windows.Forms.RibbonButton btnCadmarca;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton6;
    }
}