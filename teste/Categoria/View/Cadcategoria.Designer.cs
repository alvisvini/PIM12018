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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.Limpar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDescricao
            // 
            this.tbDescricao.BackColor = System.Drawing.Color.White;
            this.tbDescricao.CustomBackground = true;
            this.tbDescricao.Location = new System.Drawing.Point(161, 82);
            this.tbDescricao.MaxLength = 250;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(330, 23);
            this.tbDescricao.TabIndex = 3;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.Color.White;
            this.metroTextBox1.CustomBackground = true;
            this.metroTextBox1.Location = new System.Drawing.Point(44, 82);
            this.metroTextBox1.MaxLength = 250;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(88, 23);
            this.metroTextBox1.TabIndex = 4;
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Limpar.FlatAppearance.BorderSize = 0;
            this.Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpar.Image = global::MiniPack.Properties.Resources.icons8_clear_formatting_24;
            this.Limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Limpar.Location = new System.Drawing.Point(122, 136);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(81, 46);
            this.Limpar.TabIndex = 25;
            this.Limpar.Text = "Limpar";
            this.Limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Limpar.UseVisualStyleBackColor = false;
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Excluir.FlatAppearance.BorderSize = 0;
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excluir.Image = global::MiniPack.Properties.Resources.icons8_cancel_24;
            this.Excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Excluir.Location = new System.Drawing.Point(296, 136);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(81, 46);
            this.Excluir.TabIndex = 24;
            this.Excluir.Text = "Excluir";
            this.Excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Excluir.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MiniPack.Properties.Resources.icons8_mais_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(209, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 46);
            this.button1.TabIndex = 23;
            this.button1.Text = "Salvar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Descric`ao Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "SEQ";
            // 
            // Cadcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 204);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.tbDescricao);
            this.Name = "Cadcategoria";
            this.Text = "Cadastro de Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbDescricao;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}