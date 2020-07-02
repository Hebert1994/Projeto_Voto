namespace PadraoDeProjetoEmCamadas
{
    partial class frmCadastroVoto
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
            this.label4 = new System.Windows.Forms.Label();
            this.TXTURNA = new System.Windows.Forms.TextBox();
            this.TXTPESSOA = new System.Windows.Forms.TextBox();
            this.TXTIDELEICAO = new System.Windows.Forms.TextBox();
            this.TXTNUMVOTO = new System.Windows.Forms.TextBox();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.TXTNUMVOTO);
            this.painel_campos.Controls.Add(this.TXTIDELEICAO);
            this.painel_campos.Controls.Add(this.TXTPESSOA);
            this.painel_campos.Controls.Add(this.TXTURNA);
            this.painel_campos.Controls.Add(this.label4);
            this.painel_campos.Controls.Add(this.label3);
            this.painel_campos.Controls.Add(this.label2);
            this.painel_campos.Controls.Add(this.label1);
            this.painel_campos.Size = new System.Drawing.Size(444, 131);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Location = new System.Drawing.Point(3, 149);
            this.Painel_botoes.Size = new System.Drawing.Size(444, 54);
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
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID ELEIÇÃO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID PESSOA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID URNA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NUMERO DO VOTO";
            // 
            // TXTURNA
            // 
            this.TXTURNA.Location = new System.Drawing.Point(90, 40);
            this.TXTURNA.Name = "TXTURNA";
            this.TXTURNA.Size = new System.Drawing.Size(338, 20);
            this.TXTURNA.TabIndex = 4;
            // 
            // TXTPESSOA
            // 
            this.TXTPESSOA.Location = new System.Drawing.Point(90, 71);
            this.TXTPESSOA.Name = "TXTPESSOA";
            this.TXTPESSOA.Size = new System.Drawing.Size(338, 20);
            this.TXTPESSOA.TabIndex = 5;
            // 
            // TXTIDELEICAO
            // 
            this.TXTIDELEICAO.Location = new System.Drawing.Point(90, 9);
            this.TXTIDELEICAO.Name = "TXTIDELEICAO";
            this.TXTIDELEICAO.Size = new System.Drawing.Size(338, 20);
            this.TXTIDELEICAO.TabIndex = 7;
            // 
            // TXTNUMVOTO
            // 
            this.TXTNUMVOTO.Location = new System.Drawing.Point(144, 97);
            this.TXTNUMVOTO.Name = "TXTNUMVOTO";
            this.TXTNUMVOTO.Size = new System.Drawing.Size(284, 20);
            this.TXTNUMVOTO.TabIndex = 8;
            // 
            // frmCadastroVoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(457, 209);
            this.Name = "frmCadastroVoto";
            this.Text = "Cadastro Voto";
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TXTPESSOA;
        private System.Windows.Forms.TextBox TXTURNA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTIDELEICAO;
        private System.Windows.Forms.TextBox TXTNUMVOTO;
    }
}
