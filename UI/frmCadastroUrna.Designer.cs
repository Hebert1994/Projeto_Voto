namespace PadraoDeProjetoEmCamadas
{
	partial class frmCadastroUrna
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
			if(disposing && (components != null))
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
            this.TXTIPURNA = new System.Windows.Forms.TextBox();
            this.TXTDESCRICAO = new System.Windows.Forms.RichTextBox();
            this.TXTNOME = new System.Windows.Forms.TextBox();
            this.TXTId = new System.Windows.Forms.TextBox();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.TXTId);
            this.painel_campos.Controls.Add(this.TXTNOME);
            this.painel_campos.Controls.Add(this.TXTDESCRICAO);
            this.painel_campos.Controls.Add(this.TXTIPURNA);
            this.painel_campos.Controls.Add(this.label4);
            this.painel_campos.Controls.Add(this.label3);
            this.painel_campos.Controls.Add(this.label2);
            this.painel_campos.Controls.Add(this.label1);
            this.painel_campos.Size = new System.Drawing.Size(447, 218);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Location = new System.Drawing.Point(3, 233);
            this.Painel_botoes.Size = new System.Drawing.Size(447, 54);
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
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Urna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IP da urna";
            // 
            // TXTIPURNA
            // 
            this.TXTIPURNA.Location = new System.Drawing.Point(187, 24);
            this.TXTIPURNA.Name = "TXTIPURNA";
            this.TXTIPURNA.Size = new System.Drawing.Size(245, 20);
            this.TXTIPURNA.TabIndex = 4;
            // 
            // TXTDESCRICAO
            // 
            this.TXTDESCRICAO.Location = new System.Drawing.Point(9, 103);
            this.TXTDESCRICAO.Name = "TXTDESCRICAO";
            this.TXTDESCRICAO.Size = new System.Drawing.Size(423, 96);
            this.TXTDESCRICAO.TabIndex = 5;
            this.TXTDESCRICAO.Text = "";
            // 
            // TXTNOME
            // 
            this.TXTNOME.Location = new System.Drawing.Point(50, 54);
            this.TXTNOME.Name = "TXTNOME";
            this.TXTNOME.Size = new System.Drawing.Size(382, 20);
            this.TXTNOME.TabIndex = 6;
            // 
            // TXTId
            // 
            this.TXTId.Enabled = false;
            this.TXTId.Location = new System.Drawing.Point(81, 24);
            this.TXTId.Name = "TXTId";
            this.TXTId.Size = new System.Drawing.Size(46, 20);
            this.TXTId.TabIndex = 29;
            // 
            // frmCadastroUrna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(456, 295);
            this.Name = "frmCadastroUrna";
            this.Text = "Cadastro Urna";
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.TextBox TXTNOME;
        private System.Windows.Forms.RichTextBox TXTDESCRICAO;
        private System.Windows.Forms.TextBox TXTIPURNA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTId;
    }
}
