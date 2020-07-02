namespace PadraoDeProjetoEmCamadas
{
    partial class frmCadastroEleitores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidpessoa = new System.Windows.Forms.TextBox();
            this.txtideleicao = new System.Windows.Forms.TextBox();
            this.txtidempresa = new System.Windows.Forms.TextBox();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.txtidempresa);
            this.painel_campos.Controls.Add(this.txtideleicao);
            this.painel_campos.Controls.Add(this.txtidpessoa);
            this.painel_campos.Controls.Add(this.label3);
            this.painel_campos.Controls.Add(this.label2);
            this.painel_campos.Controls.Add(this.label1);
            this.painel_campos.Size = new System.Drawing.Size(440, 156);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Size = new System.Drawing.Size(440, 54);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDPessoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDEleicao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IDEmpresa";
            // 
            // txtidpessoa
            // 
            this.txtidpessoa.Location = new System.Drawing.Point(68, 32);
            this.txtidpessoa.Name = "txtidpessoa";
            this.txtidpessoa.Size = new System.Drawing.Size(366, 20);
            this.txtidpessoa.TabIndex = 3;
            // 
            // txtideleicao
            // 
            this.txtideleicao.Location = new System.Drawing.Point(68, 67);
            this.txtideleicao.Name = "txtideleicao";
            this.txtideleicao.Size = new System.Drawing.Size(366, 20);
            this.txtideleicao.TabIndex = 4;
            // 
            // txtidempresa
            // 
            this.txtidempresa.Location = new System.Drawing.Point(69, 108);
            this.txtidempresa.Name = "txtidempresa";
            this.txtidempresa.Size = new System.Drawing.Size(366, 20);
            this.txtidempresa.TabIndex = 5;
            // 
            // frmCadastroEleitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(449, 237);
            this.Name = "frmCadastroEleitores";
            this.Text = "Cadastro Eleitores";
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtidempresa;
        private System.Windows.Forms.TextBox txtideleicao;
        private System.Windows.Forms.TextBox txtidpessoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
